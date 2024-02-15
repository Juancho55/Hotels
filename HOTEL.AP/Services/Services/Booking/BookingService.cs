using Infra.Interfaces;
using Services.Services.Booking.Mapper;
using Services.Services.Booking.Models;
using System.Runtime.CompilerServices;

namespace Services.Services.Booking
{
    public class BookingService : IBookingService
    {
        private readonly IBooking booking;

        public BookingService(IBooking booking)
        {
            this.booking = booking;
        }   

        public async Task<bool> SaveBooking(RequestBookingServiceModel model)
        {
            return await booking.SaveBooking(new BookingMap().MapReq(model));
        }

        public async Task<bool> SaveThird(RequestBookingServiceModel model)
        {
            return await booking.SaveThird(new BookingMap().MapReq(model));
        }

        public async Task<List<ResponseOpenBookingServiceModel>> GetOpenBooking(RequestBookingServiceModel model)
        {
            return new BookingMap().MapRes(await booking.GetBookingOpen(new BookingMap().MapReq(model)));
        }
    }
}
