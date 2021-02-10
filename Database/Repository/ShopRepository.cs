using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShopWithAJAX.Database.EntityModel;
using ShopWithAJAX.Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using ShopWithAJAX.Database.EF;

namespace ShopWithAJAX.Database.Repository
{
    public class ShopRepository : IShopRepository
    {
        private readonly ShopContext _context;
        public ShopRepository(ShopContext context )
        {
            _context = context;
        }
        public IEnumerable<ShopEntity> GetShopEntities()
        {
            return _context.Shops.ToList();
        }

        public ShopEntity GetShopEntityById(int id)
        {
            return _context.Shops.FirstOrDefault(shop=>shop.ShopId == id);
        }
    }
}
