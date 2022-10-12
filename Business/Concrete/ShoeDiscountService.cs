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
    public class ShoeDiscountService
        : BaseService<ShoeDiscountDTO, ShoeDiscount, ShoeDiscountDTO>, IShoeDiscountService
    {
        public ShoeDiscountService(IMapper mapper, AppDBContext dBContext)
            : base(mapper, dBContext)
        {
        }

        public IEnumerable<ShoeDiscountDTO> GetColorShoe(int id)
        {
            return GetListFilter(x => x.ColorID == id);
        }

        public IEnumerable<ShoeDiscountDTO> GetCurrencyInclude()
        {

            var sportShoe = _dbSet.Include(x => x.Currency).ToList();
            var rsdto = _mapper.Map<IEnumerable<ShoeDiscountDTO>>(sportShoe);
            return rsdto;
        }

        public IEnumerable<ShoeDiscountDTO> GetCurrencyShoe(int id)
        {
            return GetListFilter(x => x.CurrencyID == id);
        }

        public IEnumerable<ShoeDiscountDTO> GetDiscountShoeID(int id)
        {
            return GetListFilter(x => x.ID == id);
        }

        public IEnumerable<ShoeDiscountDTO> GetMarkaShoe(int id)
        {
            return GetListFilter(x => x.MarkaDiscountID == id);
        }

        public IEnumerable<ShoeDiscountDTO> GetSizeShoe(int id)
        {
            return GetListFilter(x => x.SizeID == id);
        }

        public IEnumerable<ShoeDiscountDTO> SearchDiscountShoe(string s)
        {
            return GetListFilter(x => x.Name.Contains(s));
        }
    }
}
