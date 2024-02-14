using HOTEL.API.ADO.Interface;
using Microsoft.Extensions.Configuration;

namespace HOTEL.API.ADO
{
    public class HotelContext : ConnectionContext, IHotelContext
    {
        public HotelContext(IConfiguration config, string database) : base(config, database)
        {
        }
    }
}
