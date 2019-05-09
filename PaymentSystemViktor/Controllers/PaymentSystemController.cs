using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentSystemViktor.Models;
using System.Net;


namespace PaymentSystemViktor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentSystemController : Controller
    {
        private static List<PaymentSystem> paymentSystemsList =
            new List<PaymentSystem>
        {
            new PaymentSystem
            {
                Id = 1,
                Mode = "Direct",
                Method = "Direct",
                Ammount = 234,
                Currency = CurrencyTypes.UAH,
                Description = "Test Description",
                OrderId = "123test",
                CardNumber = 1111222233334444,
                ExpMounth = DateTime.Today,
                ExpYear = DateTime.Today,
                CardCVV = 666,
                Date = DateTime.Today
            },
            new PaymentSystem
            {
                Id = 2,
                Mode = "Direct",
                Method = "Direct",
                Ammount = 234,
                Currency = CurrencyTypes.UAH,
                Description = "Test Description",
                OrderId = "123test",
                CardNumber = 1111222233334444,
                ExpMounth = DateTime.Today,
                ExpYear = DateTime.Today,
                CardCVV = 666,
                Date = DateTime.Today
            }
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<PaymentSystem>> Get()
        {
            return paymentSystemsList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<PaymentSystem> Get(int id)
        {
            return paymentSystemsList.FirstOrDefault(ps => ps.Id == id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PaymentSystem paymentSystem)
        {
            if (paymentSystemsList.Any(p => p.Id == paymentSystem.Id))
            {
                return this.StatusCode((int)HttpStatusCode.Conflict);
            }
            paymentSystemsList.Add(paymentSystem);

            return this.Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
