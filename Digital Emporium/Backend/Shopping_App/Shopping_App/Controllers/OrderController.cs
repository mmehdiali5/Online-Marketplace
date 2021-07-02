using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("")]
        [HttpGet("{Id}")]
        public List<Order> Get(int Id)
        {
            return DBHelper.Get<Order, int>(Id);
        }

        [HttpPost]
        public async Task<int> Add(Order Order)
        {
            return await DBHelper.Add(Order);
        }

        [HttpPut("{Id}")]
        public async Task Update(int Id, Order Order)
        {
            await DBHelper.Update(Id, Order);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id)
        {
            await DBHelper.Delete<Order>(Id);
        }
    }
}
