using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping_App.Models;
using Microsoft.AspNet.OData;
using System.Net;
using Microsoft.AspNet.OData.Routing;

namespace Shopping_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Address> Get()
        {
            return DBHelper.Get<Address, int>(0);
        }

        [EnableQuery]
        public IEnumerable<Address> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Address, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Address address)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(address));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Address address)
        {
            await DBHelper.Update(key, address);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Address> address)
        { 
            await DBHelper.Patch(key, address);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Address>(key);
            return StatusCode(200);
        }
    }
}