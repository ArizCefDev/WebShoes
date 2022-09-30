using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class ShoeSport
    {
        public int ID { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string Image6 { get; set; }
        public string Image7 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public string Price { get; set; }
        public int Stock { get; set; }

        public int MarkaSportID { get; set; }
        public MarkaSport MarkaSport { get; set; }

        public int ColorID { get; set; }
        public Color Color { get; set; }

        public int SizeID { get; set; }
        public Size Size { get; set; }

        public int CurrencyID { get; set; }
        public Currency Currency { get; set; }

        public bool Status { get; set; }
    }
}
