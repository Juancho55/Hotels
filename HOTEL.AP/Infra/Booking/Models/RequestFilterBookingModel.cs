namespace Infra.Booking.Models
{
    public class RequestFilterBookingModel
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string City { get; set; }
        public int QuanityPersons { get; set; }
        public long ThirId { get; set; }
        public int RoomId {  get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurName { get; set; }
        public string SecondSurName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public int DocumentTypeId { get; set; }
        public int DoumentNumber { get; set; }
        public string Mail {  get; set; }   
        public string Phone { get; set; }
        public int ThirTypeId { get; set; }
        public long BookingId { get; set; }
    }
}
