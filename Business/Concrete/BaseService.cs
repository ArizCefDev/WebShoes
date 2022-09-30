using AutoMapper;
using Business.Abstract;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public abstract class BaseService<RsDTO, TEntity, RqDTO>
        : IBaseService<RsDTO, TEntity, RqDTO> where TEntity : class
    {
        protected readonly IMapper _mapper;
        protected readonly AppDBContext _dBContext;
        protected readonly DbSet<TEntity> _dbSet;

        protected BaseService(IMapper mapper, AppDBContext dBContext)
        {
            _mapper = mapper;
            _dBContext = dBContext;
            _dbSet = dBContext.Set<TEntity>();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            _dBContext.SaveChanges();
        }

        public IEnumerable<RsDTO> GetAll()
        {
            var entity = _dbSet.ToList();
            var rsdto = _mapper.Map<IEnumerable<RsDTO>>(entity);
            return rsdto;
        }

        public RsDTO GetByID(int id)
        {
            var entity = _dbSet.Find(id);
            var rsdto = _mapper.Map<RsDTO>(entity);
            return rsdto;
        }

        public IEnumerable<RsDTO> GetListFilter(Expression<Func<TEntity, bool>> filter)
        {
            var entity = _dBContext.Set<TEntity>().Where(filter).ToList();
            var rsdto = _mapper.Map<IEnumerable<RsDTO>>(entity);
            return rsdto;
        }

        public RsDTO Insert(RqDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _dbSet.Add(entity);
            _dBContext.SaveChanges();

            var rsdto = _mapper.Map<RsDTO>(entity);
            return rsdto;
        }

        public void Update(RqDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _dbSet.Update(entity);
            _dBContext.SaveChanges();

        }
    }
}
