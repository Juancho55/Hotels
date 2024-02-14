using Models.Booking;
using Models.Hotel;

namespace Services.Services.Hotel.Models
{
    public class ResponseBookingDetailServiceModel
    {
        public HotelModel hotel { get; set; }
        public BookingModel booking { get; set; }
        public RoomModel room { get; set; }
        public RoomDetailModel roomDetail { get; set; }
        public string ThirdType { get; set; }
        public List<ThirdModel> Third { get; set; }
    }
}
