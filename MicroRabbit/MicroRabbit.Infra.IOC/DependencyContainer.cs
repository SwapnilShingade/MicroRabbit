using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.bus;
using Microsoft.Extensions.DependencyInjection;
using MicrpRabbit.Banking.Application.Interfaces;
using MicrpRabbit.Banking.Application.Services;

namespace MicroRabbit.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //App Services
            services.AddTransient<IAccountService, AccountService>();

            //Data Service
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
