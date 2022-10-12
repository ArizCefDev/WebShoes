using AutoMapper;
using Business.Abstract;
using DataAccess.Context;
using DataAccess.Entity;
using DTO.DTOEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ShoeSportService
        : BaseService<ShoeSportDTO, ShoeSport, ShoeSportDTO>, IShoeSportService
    {
        public ShoeSportService(IMapper mapper, AppDBContext dBContext)
            : base(mapper, dBContext)
        {
        }

        public IEnumerable<ShoeSportDTO> GetColorShoe(int id)
        {
            return GetListFilter(x => x.ColorID == id);
        }

        public IEnumerable<ShoeSportDTO> GetCurrencyInclude()
        {
            var sportShoe = _dbSet.Include(x => x.Currency).ToList();
            var rsdto = _mapper.Map<IEnumerable<ShoeSportDTO>>(sportShoe);
            return rsdto;
        }

        public IEnumerable<ShoeSportDTO> GetCurrencyShoe(int id)
        {
            return GetListFilter(x => x.CurrencyID == id);
        }

        public IEnumerable<ShoeSportDTO> GetMarkaShoe(int id)
        {
            return GetListFilter(x => x.MarkaSportID == id);
        }

        public IEnumerable<ShoeSportDTO> GetSizeShoe(int id)
        {
            return GetListFilter(x => x.SizeID == id);
        }

        public IEnumerable<ShoeSportDTO> GetSportShoeID(int id)
        {
            return GetListFilter(x => x.ID == id);
        }

        public IEnumerable<ShoeSportDTO> SearchSportShoe(string s)
        {
            return GetListFilter(x => x.Name.Contains(s));
        }
    }
}
