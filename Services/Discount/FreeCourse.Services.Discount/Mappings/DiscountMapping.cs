using AutoMapper;
using FreeCourse.Services.Discount.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Discount.Mappings
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Models.Discount, DiscountDto>().ReverseMap();
            CreateMap<Models.Discount, DiscountCreateDto>().ReverseMap();
            CreateMap<Models.Discount, DiscountUpdateDto>().ReverseMap();

        }
    }
}
