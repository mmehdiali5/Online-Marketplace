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
    public class ColorItemController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<ColorItem> Get()
        {
            return DBHelper.Get<ColorItem, int>(0);
        }

        [EnableQuery]
        public IEnumerable<ColorItem> Get([FromODataUri] int key)
        {
            return DBHelper.Get<ColorItem, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] ColorItem colorItem)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(colorItem));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] ColorItem colorItem)
        {
            await DBHelper.Update(key, colorItem);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<ColorItem> colorItem)
        {
            await DBHelper.Patch(key, colorItem);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<ColorItem>(key);
            return StatusCode(200);
        }
    }
}