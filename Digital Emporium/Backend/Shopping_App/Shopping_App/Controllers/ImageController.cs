using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping_App.Models;
using Microsoft.AspNet.OData;
using System.Net;

namespace Shopping_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Image> Get()
        {
            return DBHelper.Get<Image, int>(0);
        }

        [EnableQuery]
        public IEnumerable<Image> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Image, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Image image)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(image));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Image image)
        {
            await DBHelper.Update(key, image);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Image> image)
        {
            await DBHelper.Patch(key, image);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Image>(key);
            return StatusCode(200);
        }
    }
}