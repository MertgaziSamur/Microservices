using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Basket.Models
{
    public class Basket
    {
        public string UserId { get; set; }
        public string DiscoundCode { get; set; }
        public List<BasketItem> BasketItems { get; set; }

        public decimal TotalPrice
        {
            get => BasketItems.Sum(x => x.Price * x.Quantity);
        }
    }
}
