using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Size
    {
        public int ID { get; set; }
        public string SizeNumber { get; set; }
        public bool Status { get; set; }
        public IEnumerable<ShoeClassic> ShoeClassics { get; set; }
        public IEnumerable<ShoeDiscount> ShoeDiscounts { get; set; }
        public IEnumerable<ShoeSport> ShoeSports { get; set; }
        public IEnumerable<ShoeStyle> ShoeStyles { get; set; }
    }
}
