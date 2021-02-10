using System;
using System.Collections.Generic;
using System.Text;
using ShopWithAJAX.BLL.Interfaces;
using ShopWithAJAX.Database.EntityModel;
using ShopWithAJAX.BLL.BusinessModel;


namespace ShopWithAJAX.BLL.Mapper
{
    public class MapperFromShopEntityToShop : IMapper<ShopEntity, Shop>
    {
        public Shop Map(ShopEntity dataForMap)
        {
            return new Shop 
            {
                ShopId = dataForMap.ShopId, 
                Adress = dataForMap.Adress, 
                Email = dataForMap.Email, 
                Name = dataForMap.Name, 
                Phone = dataForMap.Phone,
                TimeOfWork = dataForMap.TimeOfWork
            };
        }

        public IEnumerable<Shop> Map(IEnumerable<ShopEntity> arrayForMap)
        {
            if (arrayForMap == null) throw new ArgumentNullException();

            var mapresult = new List<Shop>();
            foreach (var shop in arrayForMap)
            {
                mapresult.Add(Map(shop));
            }
            return mapresult;
        }
    }
}
