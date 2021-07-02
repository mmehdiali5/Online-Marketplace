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
    public class CustomerController : ControllerBase
    {
        [EnableQuery]
        public IEnumerable<Customer> Get()
        {
            return DBHelper.Get<Customer, int>(0);
        }

        [EnableQuery]
        public IEnumerable<Customer> Get([FromODataUri] int key)
        {
            return DBHelper.Get<Customer, int>(key);
        }

        [EnableQuery]
        public async Task<IEnumerable<int>> Post([FromBody] Customer customer)
        {
            List<int> result = new List<int>();
            result.Add(await DBHelper.Add(customer));
            return result;
        }

        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Customer customer)
        {
            await DBHelper.Update(key, customer);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Customer> customer)
        {
            await DBHelper.Patch(key, customer);
            return StatusCode(200);
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] int key)
        {
            await DBHelper.Delete<Customer>(key);
            return StatusCode(200);
        }
    }
}