using ExcelDataReader;
using System.Data;
using System.Reflection;
using System.Text;

public static class ExcelRead<T> where T : class
{
    public static List<T> ReadExcelData<T>(Stream excelStream) where T : new()
    {
        // Specify the encoding to be used (e.g., Encoding.GetEncoding(1252))
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        using (var reader = ExcelReaderFactory.CreateReader(excelStream, new ExcelReaderConfiguration()
        {
            // Specify the encoding for the ExcelDataReader
            FallbackEncoding = Encoding.GetEncoding(1252)
        }))
        {
            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true // Use the first row as the column names
                }
            });

            var dataTable = result.Tables[0];
            var data = new List<T>();

            foreach (DataRow row in dataTable.Rows)
            {
                T taskInstance = new T();

                // Use reflection to dynamically map properties based on column names
                foreach (DataColumn column in dataTable.Columns)
                {
                    string propertyName = column.ColumnName;
                    PropertyInfo propertyInfo = taskInstance.GetType().GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

                    if (propertyInfo != null && row[column] != DBNull.Value)
                    {
                        object value = Convert.ChangeType(row[column], propertyInfo.PropertyType);
                        propertyInfo.SetValue(taskInstance, value);
                    }
                }

                data.Add(taskInstance);
            }

            return data;
        }
    }

}