using System.Collections.Generic;

namespace JobBoard.Domain.Entities
{
    public class Industry : Base
    {
        public string Title { get; set; }
        public IList<Company> Companies { get; set; } = new List<Company>();
    }
}