using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore_webapi_efcore.Models.DB;

namespace NetCore_webapi_efcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {//IActionResult  IHttpActionResult
            try
            {
                using (var db = new TrainWebAPIContext())
                {
                    // db.Configuration.ProxyCreationEnabled = false;

                    var resultModel = db.Departments.ToList();

                    if (resultModel == null)
                    {
                        return NotFound();
                    }

                    return Ok(resultModel);
                }
            }
            catch (Exception e)
            {
                // log.Error(e); 
                // return StatusCode(StatusCode.Status500InternalServerError);
                return StatusCode(500);
                //  ("มีปัญหาภายในฟังก์ชั่นการทำงานของ Get Department");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
