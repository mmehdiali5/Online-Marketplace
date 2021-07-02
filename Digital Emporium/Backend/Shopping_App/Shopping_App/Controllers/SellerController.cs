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
    public class SellerController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Seller> Get()
        {
            return DBHelper.Get<Seller, int>(0);
        }

        [EnableQuery]
        public IEnumerable<Seller> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Seller, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Seller seller)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(seller));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Seller seller)
        {
            await DBHelper.Update(key, seller);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Seller> seller)
        {
            await DBHelper.Patch(key, seller);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Seller>(key);
            return StatusCode(200);
        }
    }
}