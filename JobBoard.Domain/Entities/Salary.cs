namespace JobBoard.Domain.Entities
{
    public class Salary : Base
    {
        public int SalaryTypeId { get; set; }
        public string SalaryType { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public decimal? ExactSalary { get; set; }
        public decimal? MinimumSalary { get; set; }
        public decimal? MaximumSalary { get; set; }
    }
}