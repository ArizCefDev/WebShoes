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
    public class ShoeClassicService
        : BaseService<ShoeClassicDTO, ShoeClassic, ShoeClassicDTO>, IShoeClassicService
    {
        public ShoeClassicService(IMapper mapper, AppDBContext dBContext)
            : base(mapper, dBContext)
        {
        }

        public IEnumerable<ShoeClassicDTO> GetClassicShoeID(int id)
        {
            return GetListFilter(x => x.ID == id);
        }

        public IEnumerable<ShoeClassicDTO> GetColorShoe(int id)
        {
            return GetListFilter(x => x.ColorID == id);
        }

        public IEnumerable<ShoeClassicDTO> GetCurrencyInclude()
        {
            var sportShoe = _dbSet.Include(x => x.Currency).ToList();
            var rsdto = _mapper.Map<IEnumerable<ShoeClassicDTO>>(sportShoe);
            return rsdto;
        }

        public IEnumerable<ShoeClassicDTO> GetCurrencyShoe(int id)
        {
            return GetListFilter(x => x.CurrencyID == id);
        }

        public IEnumerable<ShoeClassicDTO> GetMarkaShoe(int id)
        {
            return GetListFilter(x => x.MarkaClassicID == id);
        }

        public IEnumerable<ShoeClassicDTO> GetSizeShoe(int id)
        {
            return GetListFilter(x => x.SizeID == id);
        }

        public IEnumerable<ShoeClassicDTO> SearchClassicShoe(string s)
        {
            return GetListFilter(x => x.Name.Contains(s));
        }
    }
}
