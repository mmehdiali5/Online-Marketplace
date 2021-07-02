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
    public class UserItemController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<UserItem> Get()
        {
            return DBHelper.Get<UserItem, int>(0);
        }

        [EnableQuery]
        public IEnumerable<UserItem> Get([FromODataUri] int key)
        {
            return DBHelper.Get<UserItem, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] UserItem userItem)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(userItem));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] UserItem userItem)
        {
            await DBHelper.Update(key, userItem);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<UserItem> userItem)
        {
            await DBHelper.Patch(key, userItem);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<UserItem>(key);
            return StatusCode(200);
        }
    }
}