namespace Models.Hotel
{
    public class RoomDetailModel
    {
        public int Id { get; set; }
        public decimal BaseCost { get; set; }
        public decimal Taxes { get; set; }
        public long HotelId { get; set; }
        public int RoomId { get; set; }
        public bool Ative { get; set; }
    }
}
