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
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly EmployeesService _employeeSrv;

        private readonly WorkSlotsService _wsService;

        public ManagerController(EmployeesService eservice, WorkSlotsService wservice) {

            _employeeSrv = eservice;
            _wsService = wservice;
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployeeToTheCompany([FromBody]Employee newEmployee) {

            var result = _employeeSrv.AddEmployeeToCompany(newEmployee);

            return Ok(result);
        }

        [HttpGet("FireEmployee")]
        public IActionResult FireEmployee(string id) {

            _employeeSrv.RemoveEmployee(id);

            return Ok();
        }

        [HttpGet("setQuantityOfWorkingSlots")]
        public IActionResult SetQuantityOfWorkingSlots(string companyId, int newQuantiy) {
            _wsService.SetQuantityOfWorkingSlots(companyId, newQuantiy);
            return Ok();
        }

    }
}
