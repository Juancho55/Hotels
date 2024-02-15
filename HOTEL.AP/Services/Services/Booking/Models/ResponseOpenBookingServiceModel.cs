namespace Services.Services.Booking.Models
{
    public class ResponseOpenBookingServiceModel
    {
        public int BookingId { get; set; }
        public string HotelName { get; set; }
        public string RoomType { get; set; }
        public string RoomName { get; set; }
        public string Place { get; set; }
        public decimal BaseCost { get; set; }
        public decimal Taxes { get; set; }
    }
}
