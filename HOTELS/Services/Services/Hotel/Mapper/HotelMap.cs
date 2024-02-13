using Infra.Hotel.Models;
using Services.Services.Hotel.Models;

namespace Services.Services.Hotel.Mapper
{
    public class HotelMap
    {
        public RequestFilterModel MapReq(RequestHotelServiceModel request)
        {
            return new RequestFilterModel()
            {
                Acction = request.Acction,
                Active = request.Active,
                Address = request.Address,
                BaseCost = request.BaseCost,
                BookingId = request.BookingId,
                Description = request.Description,
                HotelId = request.HotelId,
                Name = request.Name,
                Place = request.Place,
                Room = request.Room,
                RoomId = request.RoomId,
                RoomType = request.RoomType,
                Taxes = request.Taxes,
                ThirdId = request.ThirdId
            };
        }

        public List<ResponseBookingServiceModel> MapRes(List<ResponseBookingModel> response)
        {
            List<ResponseBookingServiceModel> result = new List<ResponseBookingServiceModel>();
            foreach (ResponseBookingModel responseBooking in response)
                result.Add(new ResponseBookingServiceModel()
                {
                    Address = responseBooking.Address,
                    Description = responseBooking.Description,
                    NameHotel = responseBooking.NameHotel,
                    BookingModels = responseBooking.BookingModels
                });
            return result;
        }
    }
}
