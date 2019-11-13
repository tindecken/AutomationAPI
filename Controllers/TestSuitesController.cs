using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomationAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomationAPI.Domain.Constant;
using System.IO;

namespace AutomationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSuitesController : ControllerBase
    {
        // GET: api/TestSuites
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> lstTestSuite = new List<string>();
            foreach(string sTestSuite in Directory.GetDirectories(ProjectConstant.sTestPlanFolder))
            {
                lstTestSuite.Add(sTestSuite);
            }
            return lstTestSuite;
        }

        //// GET: api/TestSuites/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/TestSuites
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/TestSuites/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}


    }
}
