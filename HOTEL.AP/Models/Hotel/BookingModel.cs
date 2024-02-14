namespace Models.Hotel
{
    public class BookingModel
    {
        public long Id { get; set; }
        public int RoomId { get; set; }
        public long ThirdId { get; set; }
        public DateTime DateS { get; set; }
        public DateTime DateE { get; set; }
        public int QuantityPerson { get; set; }
        public string? City { get; set; }

    }
}
