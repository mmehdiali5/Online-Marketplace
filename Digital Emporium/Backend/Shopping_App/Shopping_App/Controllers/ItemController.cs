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
    public class ItemController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Item> Get()
        {
            return DBHelper.Get<Item, int>(0);
        }
        /*Error/Exception of Ambiguity was occuring If use all the methods below. 
         * Error was like Mathced multiple methods ...
         * So Commented below methods(Umair)*/
/*        [EnableQuery]
        public IEnumerable<Item> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Item, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Item item)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(item));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Item item)
        {
            await DBHelper.Update(key, item);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Item> item)
        {
            await DBHelper.Patch(key, item);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Item>(key);
            return StatusCode(200);
        }
*/   
    }
}