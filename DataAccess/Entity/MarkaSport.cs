using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class MarkaSport
    {
        public int ID { get; set; }
        public string ShoeName { get; set; }
        public bool Status { get; set; }
        public IEnumerable<ShoeSport> ShoeSports { get; set; }
    }
}
