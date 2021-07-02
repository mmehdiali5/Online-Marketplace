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
    public class PaymentController : ControllerBase
    {
        [HttpGet("")]
        [HttpGet("{Id}")]
        public List<Payment> Get(int Id)
        {
            return DBHelper.Get<Payment, int>(Id);
        }

        [HttpPost]
        public async Task<int> Add(Payment Payment)
        {
            return await DBHelper.Add(Payment);
        }

        [HttpPut("{Id}")]
        public async Task Update(int Id, Payment Payment)
        {
            await DBHelper.Update(Id, Payment);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id)
        {
            await DBHelper.Delete<Payment>(Id);
        }
    }
}
