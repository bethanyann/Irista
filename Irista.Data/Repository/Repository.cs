using Irista.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Irista.Data.Repository
{
    public class Repository<TEntity> : IRepository<TKey. TEntity>
    {
        protected readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }

       
    }
}
