using AutoMapper.QueryableExtensions;
using Irista.Data.Entities;
using Irista.Data.Repository;
using Irista.POCO.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Irista.Business.Builders
{
    public class PhotoBuilder : BaseBuilder<Photo, PhotoViewModel>
    {
        public PhotoBuilder(ApplicationRepository repo) : base(repo)
        {

        }

        public override Task<PhotoViewModel> BuildSingleAsync(string id)
        {
            return _repo.Photos.Where(m => m.Id == id).ProjectTo<PhotoViewModel>(MapQueries()).FirstOrDefaultAsync();
        }
    }
}
