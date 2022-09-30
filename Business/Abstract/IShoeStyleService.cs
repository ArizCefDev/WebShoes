using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShoeStyleService
        : IBaseService<ShoeStyleDTO, ShoeStyle, ShoeStyleDTO>
    {
        IEnumerable<ShoeStyleDTO> SearchSportShoe(string s);
        IEnumerable<ShoeStyleDTO> GetCurrencyShoe(int id);
        IEnumerable<ShoeStyleDTO> GetSizeShoe(int id);
        IEnumerable<ShoeStyleDTO> GetColorShoe(int id);
        IEnumerable<ShoeStyleDTO> GetMarkaShoe(int id);
        IEnumerable<ShoeStyleDTO> GetCurrencyInclude();
    }
}
