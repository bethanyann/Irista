using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Irista.Data.Repository
{
    //this is going to be like the "Unit of work" in mosh's project
    public abstract class ApplicationRepositoryBase<TDbContext>
    {
        protected ApplicationRepositoryBase(TDbContext ctx) { }
        TDbContext Context { get; set; }


        //
        // Summary:
        //     Saves all pending entities
        //
        // Returns:
        //     true
        //     if something got saved or
        //     false
        //     if nothing saved.
        //     false
        //     does not indicate a failed save, but indicates that EF doesn't think anything
        //     needed to be changed
        public bool Save();
        //
        // Summary:
        //     Saves all pending entities
        //
        // Returns:
        //     true
        //     if something got saved or
        //     false
        //     if nothing saved.
        //     false
        //     does not indicate a failed save, but indicates that EF doesn't think anything
        //     needed to be changed
        public Task<bool> SaveAsync();

        //
        // Summary:
        //     Disposes the context
        public void Dispose();
  
    }
}
