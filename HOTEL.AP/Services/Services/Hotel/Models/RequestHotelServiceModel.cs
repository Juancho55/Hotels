namespace Services.Services.Hotel.Models
{
    public class RequestHotelServiceModel
    {
        public int Acction { get; set; }
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public string Place { get; set; }
        public string RoomType { get; set; }
        public int RoomId { get; set; }
        public decimal BaseCost { get; set; }
        public decimal Taxes { get; set; }
        public bool Active { get; set; }
        public long ThirdId { get; set; }
        public long BookingId { get; set; }
    }
}
