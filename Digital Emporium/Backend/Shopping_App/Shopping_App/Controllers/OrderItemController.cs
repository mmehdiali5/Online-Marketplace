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
    public class OrderItemController : ControllerBase
    {
        [HttpGet("")]
        [HttpGet("{Id}")]
        public List<OrderItem> Get(int Id)
        {
            return DBHelper.Get<OrderItem, int>(Id);
        }

        [HttpPost]
        public async Task<int> Add(OrderItem OrderItem)
        {
            return await DBHelper.Add(OrderItem);
        }

        [HttpPut("{Id}")]
        public async Task Update(int Id, OrderItem OrderItem)
        {
            await DBHelper.Update(Id, OrderItem);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id)
        {
            await DBHelper.Delete<OrderItem>(Id);
        }
    }
}
