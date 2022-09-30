using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class ColorDTO
    {
        public int ID { get; set; }
        public string ColorName { get; set; }
        public bool Status { get; set; }
        public IEnumerable<ShoeClassicDTO> ShoeClassicDTOs { get; set; }
        public IEnumerable<ShoeDiscountDTO> ShoeDiscountDTOs { get; set; }
        public IEnumerable<ShoeSportDTO> ShoeSportDTOs { get; set; }
        public IEnumerable<ShoeStyleDTO> ShoeStyleDTOs { get; set; }
    }
}
