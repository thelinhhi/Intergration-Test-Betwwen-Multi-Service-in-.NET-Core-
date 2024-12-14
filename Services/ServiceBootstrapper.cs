
using Application.Service;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ServiceBootstrapper
    {
        public static void UseServices(this IServiceCollection services)
        {
            services.AddTransient<IContractService, ContractService>();
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}
