using System;

namespace JobBoard.Domain.Entities
{
    public class Job : Base
    {
        public DateTime ActivationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ApplyUrl { get; set; }
        public bool IsInternalApply { get; set; } = true;
        public string SeniorityLevel { get; set; }
        public bool IsPermanent { get; set; }
        public bool IsContract { get; set; }
        public bool IsFullTime { get; set; }
        public bool IsParTime { get; set; }
        public bool IsRemote { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int SalaryId { get; set; }
        public Salary Salary { get; set; }
        public bool IsSuspended { get; set; } = false;
    }
}