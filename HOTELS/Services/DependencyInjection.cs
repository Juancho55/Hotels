using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.Hotel;
using System.Reflection;

namespace Services
{
    public class DependencyInjection
    {
        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSingleton<IHotelService, HotelService>();
        }
    }
}
