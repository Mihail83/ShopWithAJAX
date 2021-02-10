using System;
using System.Collections.Generic;
using System.Text;
using ShopWithAJAX.Database.EntityModel;

namespace ShopWithAJAX.Database.Interfaces
{
    public interface IShopRepository
    {       
        public IEnumerable<ShopEntity> GetShopEntities();
        public ShopEntity GetShopEntityById(int id);
    }
}
