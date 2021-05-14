namespace JobBoard.Domain.Entities
{
    public class Address : Base
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
    }
}