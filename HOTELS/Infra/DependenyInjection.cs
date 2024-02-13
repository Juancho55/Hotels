using HOTELSADO;
using HOTELSADO.Interface;
using Infra.Hotel;
using Infra.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class DependenyInjection
    {
        public static void  AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IHotelContext, HotelContext>(db => new HotelContext(configuration, "HotelConnectionString"));
            services.AddSingleton<IHotel, HotelInfra>();
        }
    }
}
