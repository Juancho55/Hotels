using Infra.Interfaces;
using Services.Services.Booking.Mapper;
using Services.Services.Booking.Models;

namespace Services.Services.Booking
{
    public interface IBookingService
    {
        public Task<bool> SaveBooking(RequestBookingServiceModel model);
        public Task<bool> SaveThird(RequestBookingServiceModel model);
        public Task<List<ResponseOpenBookingServiceModel>> GetOpenBooking(RequestBookingServiceModel model);
    }
}
