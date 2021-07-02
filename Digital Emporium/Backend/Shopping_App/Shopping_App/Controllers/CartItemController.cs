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
    public class CartItemController : ControllerBase
    {
        [HttpGet("")]
        [HttpGet("{Id}")]
        public List<CartItem> Get(int Id)
        {
            return DBHelper.Get<CartItem, int>(Id);
        }

        [HttpPost]
        public async Task<int> Add(CartItem CartItem)
        {
            return await DBHelper.Add(CartItem);
        }

        [HttpPut("{Id}")]
        public async Task Update(int Id, CartItem CartItem)
        {
            await DBHelper.Update(Id, CartItem);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id)
        {
            await DBHelper.Delete<CartItem>(Id);
        }

        [HttpDelete("Customer/{CustomerId}")]
        public async Task DeleteCartItems(int CustomerId)
        {
            await DBHelper.Delete<CartItem>(CustomerId, "CustomerId");
        }
    }
}