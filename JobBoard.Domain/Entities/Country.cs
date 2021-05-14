using System.Collections.Generic;

namespace JobBoard.Domain.Entities
{
    public class Country : Base
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public IList<State> States { get; set; } = new List<State>();
    }
}