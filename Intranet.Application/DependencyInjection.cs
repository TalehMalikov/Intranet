using AutoMapper;
using Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateList;
using Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateOne;
using Intranet.Application.Mappings;
using Intranet.Domain.Dtos.ServiceTemporaries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Intranet.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRequestHandler<CreateServiceTemporaryListCommand, List<GetServiceTemporaryDto>>), typeof(CreateServiceTemporaryCommandListHandler));
            services.AddScoped(typeof(IRequestHandler<CreateServiceTemporaryCommand, GetServiceTemporaryDto>), typeof(CreateServiceTemporaryCommandHandler));

            services.AddMediatR(Assembly.GetExecutingAssembly());

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new GeneralMapping());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            //services.AddFluentValidationAutoValidation();
            //services.AddValidatorsFromAssemblyContaining<CreateProductCommandValidator>();

            return services;
        }
    }
}
