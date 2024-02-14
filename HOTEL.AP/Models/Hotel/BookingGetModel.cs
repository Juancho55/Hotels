namespace Models.Hotel
{
    public class BookingGetModel
    {
        public HotelModel Hotel { get; set; }

        public List<BookingModel> Bookings { get; set; }
    }
}
