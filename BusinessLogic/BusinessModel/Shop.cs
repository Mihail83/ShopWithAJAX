using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopWithAJAX.BLL.BusinessModel
{  
    public class Shop
    {        
        public int ShopId { get; set; }
        public string Name { get; set; }        
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TimeOfWork { get; set; }
    }
}
