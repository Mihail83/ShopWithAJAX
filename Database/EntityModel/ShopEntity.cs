using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopWithAJAX.Database.EntityModel
{
    [Table("Shops")]
    public class ShopEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShopId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TimeOfWork { get; set; }        
        //public List<GoodEntity> Goods { get; set; }
        
    }
}
