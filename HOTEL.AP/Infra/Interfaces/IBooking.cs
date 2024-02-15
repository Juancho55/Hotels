
using Infra.Booking.Models;
using Infra.Hotel.Models;

namespace Infra.Interfaces
{
    public  interface IBooking
    {
        public Task<bool> SaveBooking(RequestFilterBookingModel request);
        public Task<bool> SaveThird(RequestFilterBookingModel request);
        public Task<List<ResponseOpenBooking>> GetBookingOpen(RequestFilterBookingModel request);
    }
}
