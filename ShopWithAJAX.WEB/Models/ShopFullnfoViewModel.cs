using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopWithAJAX.BLL.BusinessModel;
using System.Text;

namespace ShopWithAJAX.WEB.Models
{
    public class ShopFullnfoViewModel
    {
        public ShopFullnfoViewModel(Shop shop)
        {
            Adress = shop.Adress;
            Phone = shop.Phone;
            Email = shop.Email;
        }        
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
