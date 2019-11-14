using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutomationAPI.Domain.Constant;
using AutomationAPI.Domain.Models;
using AutomationAPI.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        public CategoriesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        // GET: api/Categories
        [HttpGet]
        public IEnumerable<CategoryResource> Get()
        {
            List<Category> lstCategories = new List<Category>();
            foreach (string cat in Directory.GetDirectories(ProjectConstant.sTestPlanFolder))
            {
                Category tempCat = new Category(cat);
                lstCategories.Add(tempCat);
            }
            var result = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(lstCategories);
            //IEnumerable<Category> result = lstCategories;
            return result;
        }
    }
}