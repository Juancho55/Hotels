using Models.Hotel;

namespace Services.Services.Hotel.Models
{
    public class ResponseBookingServiceModel
    {
        public string NameHotel { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public List<BookingModel> BookingModels { get; set; }
    }
}
