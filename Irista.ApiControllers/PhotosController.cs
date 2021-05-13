using Irista.Business.Builders;
using Irista.POCO.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace Irista.ApiControllers
{
    [Authorize]
    [Route("api/Photos")]
    [ApiController]
    public class PhotosController : Controller
    {
        private readonly PhotoBuilder _photoBuilder;

        public PhotosController(PhotoBuilder photoBuilder)
        {
            _photoBuilder = photoBuilder;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string id)
        {
            var model = await _photoBuilder.BuildSingleAsync(id);
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PhotoViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            model = await _photoBuilder.AddAsync(model);
            return Ok(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PhotoViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            model = await _photoBuilder.UpdateAsync(model);
            return Ok(model);
        }

    }
}
