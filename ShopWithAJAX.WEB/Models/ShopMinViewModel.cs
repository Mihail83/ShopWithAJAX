using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopWithAJAX.BLL.BusinessModel;

namespace ShopWithAJAX.WEB.Models
{
    public class ShopMinViewModel
    {
        public ShopMinViewModel()
        { }
        public ShopMinViewModel(Shop shop)
        {
            ShopId = shop.ShopId;
            Name = shop.Name;
            TimeOfWork = shop.TimeOfWork;
        }
        public int ShopId { get; set; }
        public string Name { get; set; }        
        public string TimeOfWork { get; set; }
    }
}
