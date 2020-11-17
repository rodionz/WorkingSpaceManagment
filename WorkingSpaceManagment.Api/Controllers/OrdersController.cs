using HotChairsApp.BL;
using HotChairsApp.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkingSpaceManagment.Api.Controllers
{
    //[Route("[controller]")]
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {



        private readonly OrdersService _orderSrv;

        public OrdersController(OrdersService oServ) {
            _orderSrv = oServ;
        }


        // GET: api/<OrdersController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public async Task<IActionResult> Get() {
            List<Order> orders = await _orderSrv.GetAllOrders();
            return Ok(orders);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
