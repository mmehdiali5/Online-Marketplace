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
    public class ColorController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Color> Get()
        {
            return DBHelper.Get<Color, int>(0);
        }

        [EnableQuery]
        public IEnumerable<Color> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Color, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Color color)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(color));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Color color)
        {
            await DBHelper.Update(key, color);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Color> color)
        {
            await DBHelper.Patch(key, color);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Color>(key);
            return StatusCode(200);
        }
    }
}