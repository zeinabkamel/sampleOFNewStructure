﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}