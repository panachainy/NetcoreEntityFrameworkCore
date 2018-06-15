
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore_webapi_efcore.Models.DB;

namespace NetCore_webapi_efcore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {

        private readonly ILogger _logger;

        public EmployeesController(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger<EmployeesController>();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (TrainWebAPIContext db = new TrainWebAPIContext())
                {
                    return Ok(db.Employees.ToList());
                }
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute GET");
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employees model)
        {
            try
            {
                return Created("", null);
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute POST");
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employees model)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute PUT");
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute DELETE");
                return BadRequest();
            }
        }
    }
}
