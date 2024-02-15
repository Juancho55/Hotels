using HOTEL.AP.Models.Hotel;
using Services.Services.Hotel.Models;

namespace HOTEL.AP.Models.Mapper
{
    public class HotelMapperAPI
    {
        public RequestHotelServiceModel MapReq(HotelRequestFilterModel model)
        {
            return new RequestHotelServiceModel
            {
                Acction = model.Acction,
                Active = model.Active,
                Address = model.Address,
                BaseCost = model.BaseCost.HasValue ? model.BaseCost.Value : 0,
                Taxes = model.Taxes.HasValue ? model.Taxes.Value : 0,
                BookingId = model.BookingId.HasValue ? model.BookingId.Value : 0,
                Description = model.Description,
                HotelId = model.HotelId.HasValue ? model.HotelId.Value : 0,
                Name = model.Name,
                Place = model.Place,
                Room = model.Room,
                RoomType = model.RoomType,
                ThirdId = model.ThirdId,
                RoomId = model.RoomId.HasValue ? model.RoomId.Value : 0
            };
        }

        public List<ResponseBookingModel> MapRes(List<ResponseBookingServiceModel> model)
        {
            List<ResponseBookingModel> result = new List<ResponseBookingModel>();
            foreach (ResponseBookingServiceModel responseBooking in model)
                result.Add(new ResponseBookingModel()
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
