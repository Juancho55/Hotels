namespace Models.Booking
{
    public class ThirdModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurName { get; set; }
        public string SecondSurName { get; set; }
        public DateTime BirthDay { get; set; }
        public int GenderId { get; set; }
        public int DocumentTypeId { get; set; }
        public int DoumentNumer {  get; set; }
        public string Mail {  get; set; }
        public string Phone {  get; set; }
        public int ThirdTypeId {  get; set; }
    }
}
