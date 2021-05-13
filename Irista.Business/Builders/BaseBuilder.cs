using AutoMapper;
using Irista.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Irista.Business.Builders
{
    public abstract class BaseBuilder<TEntity, TViewModel >//, TListModel>
    {
        protected ApplicationRepository _repo { get; set; }
        
        protected BaseBuilder(ApplicationRepository repo)
        {
            _repo = repo;
        }

        protected virtual MapperConfiguration MapQueries()
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<TEntity, TViewModel>();
            });
        }

        protected virtual MapperConfiguration MapAdd()
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<TViewModel, TEntity>();
            });
        }

        protected virtual MapperConfiguration MapUpdate()
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<TViewModel, TEntity>();
            });
        }

        public virtual Task<TViewModel> BuildSingleAsync(string id)
        {
            return Task.FromResult(default(TViewModel));
        }

        public virtual Task<TViewModel> AddAsync(TViewModel model)
        {
            return Task.FromResult(default(TViewModel));
        }
        public virtual Task<TViewModel> UpdateAsync(TViewModel model)
        {
            return Task.FromResult(default(TViewModel));
        }

        public virtual Task DeleteAsync(string id)
        {
            return Task.FromResult(0);
        }

        //protected virtual MapperConfiguration MapGridQueries()
        //{
        //    return new MapperConfiguration(config =>
        //    {
        //        config.CreateMap<TEntity, TGridModel>();
        //    });
        //}

        //protected virtual MapperConfiguration MapDropDownLists()
        //{
        //    return new MapperConfiguration(config =>
        //    {
        //        config.CreateMap<TEntity, DropDownListModel>();
        //    });
        //}

        //public virtual Task<List<TListModel>> BuildListAsync(DataSourceRequest request, TQueryFilterModel queryModel = null)
        //{
        //    return Task.FromResult(new List<TListModel>());
        //}

        //public virtual Task<DataSourceResult> BuildGridAsync(DataSourceRequest request, TQueryFilterModel queryModel = null)
        //{
        //    return Task.FromResult(default(DataSourceResult));
        //}


        //public virtual Task<List<DropDownListModel>> BuildDropDownListAsync(TQueryFilterModel queryModel = null)
        //{
        //    return Task.FromResult(new List<DropDownListModel>());
        //}
    }
}
