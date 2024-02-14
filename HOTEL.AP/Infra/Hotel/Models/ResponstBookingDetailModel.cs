
using Models.Booking;
using Models.Hotel;

namespace Infra.Hotel.Models
{
    public class ResponstBookingDetailModel
    {
        public HotelModel hotel { get; set; }
        public BookingModel booking { get; set; }
        public RoomModel room { get; set; }
        public RoomDetailModel roomDetail { get; set; }
        public string ThirdType { get; set; }
        public List<ThirdModel> Third { get; set; }
    }
}
