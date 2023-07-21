using Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateList;
using Intranet.Domain.Dtos.ServiceTemporaries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTemporaryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ServiceTemporaryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("upload ExcelFile")]
        public IActionResult UploadExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Excel file is missing.");

            try
            {
                using (var stream = file.OpenReadStream())
                {
                    var data = ExcelRead<CreateServiceTemporaryDto>.ReadExcelData<CreateServiceTemporaryDto>(stream);

                    if (data == null || !data.Any())
                        return BadRequest("No data found in the Excel file.");
                    var response = _mediator.Send(new CreateServiceTemporaryListCommand ( data ));
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
