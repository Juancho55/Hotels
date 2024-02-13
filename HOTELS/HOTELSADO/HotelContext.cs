using HOTELSADO.Interface;
using Microsoft.Extensions.Configuration;

namespace HOTELSADO
{
    public class HotelContext : ConnectionContext, IHotelContext
    {
        public HotelContext(IConfiguration config, string database) : base(config, database)
        {
        }
    }
}
