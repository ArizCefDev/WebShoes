using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class ShoeDiscountDTO
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
        public DateTime LastDate { get; set; }
        public string OldPrice { get; set; }
        public string Price { get; set; }
        public int Stock { get; set; }

        public int MarkaDiscountID { get; set; }
        public MarkaDiscountDTO MarkaDiscountDTO { get; set; }

        public int ColorID { get; set; }
        public ColorDTO ColorDTO { get; set; }

        public int SizeID { get; set; }
        public SizeDTO SizeDTO { get; set; }

        public int CurrencyID { get; set; }
        public CurrencyDTO CurrencyDTO { get; set; }
        public string CurrencyName { get; set; }

        public bool Status { get; set; }
    }
}
