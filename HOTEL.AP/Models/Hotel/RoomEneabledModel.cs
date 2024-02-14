namespace Models.Hotel
{
    public class RoomEneabledModel
    {
        public BookingModel Booking { get; set; }
        public RoomModel Room { get; set; }
        public List<RoomDetailModel> RoomDetail { get; set; }
    }
}
