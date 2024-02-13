
using Models.Booking;

namespace Models.Hotel
{
    public class GetDetailBookingModel
    {
        public HotelModel hotel { get; set; }
        public BookingModel booking { get; set; }
        public RoomModel room { get; set; }
        public RoomDetailModel roomDetail { get; set; }
        public List<ThirdModel> Third { get; set; }
    }
}
