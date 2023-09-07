using AutoMapper;
using FreeCourse.Services.Basket.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Basket.Mappings
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<Models.Basket, BasketDto>().ReverseMap();
        }
    }
}
