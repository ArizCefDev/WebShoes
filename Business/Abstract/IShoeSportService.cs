using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShoeSportService
        : IBaseService<ShoeSportDTO, ShoeSport, ShoeSportDTO>
    {
        IEnumerable<ShoeSportDTO> SearchSportShoe(string s);
        IEnumerable<ShoeSportDTO> GetCurrencyShoe(int id);
        IEnumerable<ShoeSportDTO> GetSizeShoe(int id);
        IEnumerable<ShoeSportDTO> GetColorShoe(int id);
        IEnumerable<ShoeSportDTO> GetMarkaShoe(int id);
        IEnumerable<ShoeSportDTO> GetCurrencyInclude();
    }
}
