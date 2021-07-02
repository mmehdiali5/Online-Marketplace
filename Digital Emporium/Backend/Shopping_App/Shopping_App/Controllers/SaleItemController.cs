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
    public class SaleItemController : ControllerBase
    {
        [HttpGet("")]
        [HttpGet("{Id}")]
        public List<SaleItem> Get(int Id)
        {
            return DBHelper.Get<SaleItem, int>(Id);
        }

        [HttpPost]
        public async Task<int> Add(SaleItem SaleItem)
        {
            return await DBHelper.Add(SaleItem);
        }

        [HttpPut("{Id}")]
        public async Task Update(int Id, SaleItem SaleItem)
        {
            await DBHelper.Update(Id, SaleItem);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id)
        {
            await DBHelper.Delete<SaleItem>(Id);
        }
    }
}
