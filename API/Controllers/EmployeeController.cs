using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Core.Model;



namespace API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DbContextApplication _context;
        public EmployeeController(DbContextApplication context)
        {
            this._context = context;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeModel>> GetEmployee(int id)
        {
        
            EmployeeModel emp = _context.employee.FirstOrDefault<EmployeeModel>(u => u.Id == id);
            return Ok(emp);
        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeeModel>>> GetAllEmployee()
        {
            return Ok(await _context.employee.ToListAsync());
        }
    }
}