using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.TransferServicesDependanceInjection
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ITransferService, TransferService>();
        }
    }
}
