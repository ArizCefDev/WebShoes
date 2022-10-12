using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShoeDiscountService
        : IBaseService<ShoeDiscountDTO, ShoeDiscount, ShoeDiscountDTO>
    {
        IEnumerable<ShoeDiscountDTO> SearchDiscountShoe(string s);
        IEnumerable<ShoeDiscountDTO> GetDiscountShoeID(int id);
        IEnumerable<ShoeDiscountDTO> GetCurrencyShoe(int id);
        IEnumerable<ShoeDiscountDTO> GetSizeShoe(int id);
        IEnumerable<ShoeDiscountDTO> GetColorShoe(int id);
        IEnumerable<ShoeDiscountDTO> GetMarkaShoe(int id);
        IEnumerable<ShoeDiscountDTO> GetCurrencyInclude();
    }
}
