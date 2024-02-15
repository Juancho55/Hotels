using Models.Hotel;

namespace HOTEL.AP.Models.Hotel
{
    public class ResponseBookingModel
    {
        public string NameHotel { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public List<BookingModel> BookingModels { get; set; }
    }
}
