using AutoMapper;
using FreeCourse.Services.Basket.Dtos;
using FreeCourse.Services.Basket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Basket.Mappings
{
    public class BasketItemMapping : Profile
    {
        public BasketItemMapping()
        {
            CreateMap<BasketItem, BasketItemDto>().ReverseMap();
        }
    }
}
