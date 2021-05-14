namespace JobBoard.Domain.Entities
{
    public class Company : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public string ImageUrl { get; set; }
    }
}