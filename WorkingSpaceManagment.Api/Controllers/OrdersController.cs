using HotChairsApp.BL;
using HotChairsApp.Model;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
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


        [HttpGet("Start")]
        public async Task<IActionResult> Start()
        {
            List<Order> orders = await _orderSrv.GetAllOrders();
            return Ok(orders);
        }

        [HttpGet("getordersByCompanie")]
        public IActionResult GetordersByCompanie(string companyId)
        {
            List<BroadOrder> orders =  _orderSrv.GettOrdersForCompany(companyId);
            return Ok(orders);
        }

        [HttpGet("getcompanies")]
        public  IActionResult GetCompanies()
        {
            List<Company> companies = _orderSrv.GetAllCompanies();
            return Ok(companies);
        }

        [HttpGet("GetAvailiableSlots")]
        public IActionResult GetAvailiableSlots(string companyId, string dateFrom, string dateTo)
        {
                  
            List<WorkStation> freeWorkStations = _orderSrv.GetAvailiableSlots(companyId, dateFrom, dateTo);
            return Ok(freeWorkStations);
        }

        [HttpGet("makeBooking")]
        public IActionResult MakeBooking(string companyId, string dateFrom, string dateTo, string workStationId)
        {

            _orderSrv.MakeBooking(companyId, dateFrom, dateTo, workStationId);
            return Ok();
        }

        public  IActionResult Get() {
            string message = "Server Satrted...";
            return Ok(message);
        }



    }
}
