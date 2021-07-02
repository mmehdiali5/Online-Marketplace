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
    public class FeaturedItemController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<FeaturedItem> Get()
        {
            return DBHelper.Get<FeaturedItem, int>(0);
        }

        [EnableQuery]
        public IEnumerable<FeaturedItem> Get([FromODataUri] int key)
        {
            return DBHelper.Get<FeaturedItem, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] FeaturedItem featuredItem)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(featuredItem));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] FeaturedItem featuredItem)
        {
            await DBHelper.Update(key, featuredItem);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<FeaturedItem> featuredItem)
        {
            await DBHelper.Patch(key, featuredItem);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<FeaturedItem>(key);
            return StatusCode(200);
        }
    }
}