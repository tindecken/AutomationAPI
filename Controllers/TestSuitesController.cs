using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomationAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomationAPI.Domain.Constant;
using System.IO;
using AutoMapper;
using AutomationAPI.Resources;
using AutomationAPI.Domain.Models;

namespace AutomationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSuitesController : ControllerBase
    {
        private readonly IMapper _mapper;
        public TestSuitesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{categoryName}/{testSuiteName}")]
        public string Get(string categoryName, string testSuiteName)
        {
            //Check Category exist or not
            if (!Directory.Exists(Path.Combine(ProjectConstant.sTestPlanFolder, categoryName)))
            {
                throw new ArgumentException(
                 $"Not found Category {categoryName}.", nameof(categoryName));
            };

            //Check TestSuite exist or not
            if (!System.IO.File.Exists(Path.Combine(ProjectConstant.sTestPlanFolder, categoryName, testSuiteName))) {
                return null;
            }
            //List<Category> lstCategories = new List<Category>();
            //foreach (string cat in Directory.GetDirectories(ProjectConstant.sTestPlanFolder))
            //{
            //    Category tempCat = new Category(cat);
            //    lstCategories.Add(tempCat);
            //}
            //var result = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(lstCategories);
            ////IEnumerable<Category> result = lstCategories;
            return null;
        }
    }
}
