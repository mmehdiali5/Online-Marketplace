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
    public class ReviewController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Review> Get()
        {
            return DBHelper.Get<Review, int>(0);
        }

        [EnableQuery]
        public IEnumerable<Review> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Review, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Review review)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(review));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Review review)
        {
            await DBHelper.Update(key, review);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Review> review)
        {
            await DBHelper.Patch(key, review);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Review>(key);
            return StatusCode(200);
        }
    }
}