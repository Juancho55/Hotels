using HOTEL.AP.Models.Booking;
using HOTEL.AP.Models.Hotel;
using Services.Services.Booking.Models;
using Services.Services.Hotel.Models;

namespace HOTEL.AP.Models.Mapper
{
    public class BookingMapper
    {
        public RequestBookingServiceModel MapReq(BookingRequestModel model)
        {
            return new RequestBookingServiceModel
            {
                BookingId = model.BookingId,
                BirthDate = model.BirthDate,
                City = model.City,
                DateEnd = model.DateEnd,
                DateStart = model.DateStart,
                DocumentTypeId = model.DocumentTypeId,
                DoumentNumber = model.DoumentNumber,
                FirstName = model.FirstName,
                FirstSurName = model.FirstSurName,
                GenderId = model.GenderId,
                Mail = model.Mail,
                Phone = model.Phone,
                QuanityPersons = model.QuanityPersons,
                RoomId = model.RoomId,
                SecondName = model.SecondName,
                SecondSurName = model.SecondSurName,
                ThirId = model.ThirId,
                ThirTypeId = model.ThirTypeId
            };
        }

        public List<ResponseOpenBookingModel> MapRes(List<ResponseOpenBookingServiceModel> model)
        {
            List<ResponseOpenBookingModel> result = new List<ResponseOpenBookingModel>();
            foreach (ResponseOpenBookingServiceModel item in model)
                result.Add(new ResponseOpenBookingModel()
                {
                    BaseCost = item.BaseCost,
                    BookingId = item.BookingId,
                    HotelName = item.HotelName,
                    Place = item.Place,
                    RoomName = item.RoomName,
                    RoomType = item.RoomType,
                    Taxes = item.Taxes
                });
            return result;
        }
    }
}
