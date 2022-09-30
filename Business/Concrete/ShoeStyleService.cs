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
    public class ShoeStyleService
        : BaseService<ShoeStyleDTO, ShoeStyle, ShoeStyleDTO>, IShoeStyleService
    {
        public ShoeStyleService(IMapper mapper, AppDBContext dBContext)
            : base(mapper, dBContext)
        {
        }

        public IEnumerable<ShoeStyleDTO> GetColorShoe(int id)
        {
            return GetListFilter(x => x.ColorID == id);
        }

        public IEnumerable<ShoeStyleDTO> GetCurrencyInclude()
        {
            var sportShoe = _dbSet.Include(x => x.Currency).ToList();
            var rsdto = _mapper.Map<IEnumerable<ShoeStyleDTO>>(sportShoe);
            return rsdto;
        }

        public IEnumerable<ShoeStyleDTO> GetCurrencyShoe(int id)
        {
            return GetListFilter(x => x.CurrencyID == id);
        }

        public IEnumerable<ShoeStyleDTO> GetMarkaShoe(int id)
        {
            return GetListFilter(x => x.MarkaStyleID == id);
        }

        public IEnumerable<ShoeStyleDTO> GetSizeShoe(int id)
        {
            return GetListFilter(x => x.SizeID == id);
        }

        public IEnumerable<ShoeStyleDTO> SearchSportShoe(string s)
        {
            return GetListFilter(x => x.Name.Contains(s));
        }
    }
}
