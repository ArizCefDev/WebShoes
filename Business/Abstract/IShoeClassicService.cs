using Business.Concrete;
using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShoeClassicService
        : IBaseService<ShoeClassicDTO, ShoeClassic, ShoeClassicDTO>
    {
        IEnumerable<ShoeClassicDTO> SearchClassicShoe(string s);
        IEnumerable<ShoeClassicDTO> GetClassicShoeID(int id);
        IEnumerable<ShoeClassicDTO> GetCurrencyShoe(int id);
        IEnumerable<ShoeClassicDTO> GetSizeShoe(int id);
        IEnumerable<ShoeClassicDTO> GetColorShoe(int id);
        IEnumerable<ShoeClassicDTO> GetMarkaShoe(int id);
        IEnumerable<ShoeClassicDTO> GetCurrencyInclude();
    }
}
