using Infra.Booking.Models;
using Services.Services.Booking.Models;

namespace Services.Services.Booking.Mapper
{
    public class BookingMap
    {
        public RequestFilterBookingModel MapReq(RequestBookingServiceModel model)
        {
            return new RequestFilterBookingModel()
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

        public List<ResponseOpenBookingServiceModel> MapRes(List<ResponseOpenBooking> model)
        {
            List<ResponseOpenBookingServiceModel> result = new List<ResponseOpenBookingServiceModel>();

            foreach (ResponseOpenBooking item in model)
                result.Add(new ResponseOpenBookingServiceModel()
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
