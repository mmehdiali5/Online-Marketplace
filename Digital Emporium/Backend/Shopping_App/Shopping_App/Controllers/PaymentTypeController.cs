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
    public class PaymentTypeController : ControllerBase
    {
        [HttpGet("")]
        [HttpGet("{Id}")]
        public List<PaymentType> Get(int Id)
        {
            return DBHelper.Get<PaymentType, int>(Id);
        }

        [HttpPost]
        public async Task<int> Add(PaymentType PaymentType)
        {
            return await DBHelper.Add(PaymentType);
        }

        [HttpPut("{Id}")]
        public async Task Update(int Id, PaymentType PaymentType)
        {
            await DBHelper.Update(Id, PaymentType);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(int Id)
        {
            await DBHelper.Delete<PaymentType>(Id);
        }
    }
}
