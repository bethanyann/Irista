using Irista.Data.Context;
using Irista.Data.Entities;
using Irista.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Irista.Data.Repository
{
    public class ApplicationRepository
    {
        public IRepository<string,Photo> Photos { get; set; }
        public IRepository<string,Album> Albums { get; set; }
        public IRepository<string,Tag> Tags { get; set; }
        public IRepository<string,Metadata> Metadata { get; set; }
        public IRepository<string,Location> Location { get; set; }
        public IRepository<string,Comment> Comments { get; set; }

        public ApplicationRepository(ApplicationDbContext ctx, IHttpContextAccessor contextAccessor) 
        {

        }

        public ApplicationRepository(ApplicationDbContext ctx) 
        {
            InitializeRepository();
        }

        public void InitializeRepository()
        {
            //Photos = new Repository<string,Photo>(Context);
        }
    }
}
