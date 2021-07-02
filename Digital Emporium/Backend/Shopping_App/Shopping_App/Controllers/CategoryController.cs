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
    public class CategoryController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Category> Get()
        {
            return DBHelper.Get<Category, int>(0);
        }

        [EnableQuery]
        public IEnumerable<Category> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Category, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Category category)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(category));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Category category)
        {
            await DBHelper.Update(key, category);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Category> category)
        {
            await DBHelper.Patch(key, category);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Category>(key);
            return StatusCode(200);
        }
    }
}