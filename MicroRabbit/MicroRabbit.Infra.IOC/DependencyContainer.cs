using MediatR;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.bus;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.Eventhandlers;
using Microsoft.Extensions.DependencyInjection;
using MicrpRabbit.Banking.Application.Interfaces;
using MicrpRabbit.Banking.Application.Services;
using MicrpRabbit.Transfer.Application.Interfaces;
using MicrpRabbit.Transfer.Application.Services;

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
            services.AddTransient<ITransferService, TransferService>();

            //Data Service
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();

            //Domain Commands
            services.AddTransient<IRequestHandler<CreatTransferCommand, bool>, TransferCommandHandler>();

            //Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
        }
    }
}
