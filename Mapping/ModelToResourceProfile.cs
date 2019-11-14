﻿using AutoMapper;
using AutomationAPI.Domain.Models;
using AutomationAPI.Models;
using AutomationAPI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomationAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>().ForMember(dest => dest.TestSuiteResources, opts => opts.MapFrom(source => source.TestSuites));
            CreateMap<TestSuite, TestSuiteResource>();
        }
    }
}
