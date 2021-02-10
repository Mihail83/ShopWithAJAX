using System;
using System.Collections.Generic;
using System.Text;
using ShopWithAJAX.BLL.Interfaces;
using ShopWithAJAX.Database.EntityModel;
using ShopWithAJAX.BLL.BusinessModel;

namespace ShopWithAJAX.BLL.Mapper
{
    public class MapperFromShopToShopEntity : IMapper<Shop, ShopEntity>
    {
        public ShopEntity Map(Shop dataForMap)
        {
            if (dataForMap == null) throw new ArgumentNullException();
            return new ShopEntity
            {
                ShopId = dataForMap.ShopId,
                Adress = dataForMap.Adress,
                Email = dataForMap.Email,
                Name = dataForMap.Name,
                Phone = dataForMap.Phone,
                TimeOfWork = dataForMap.TimeOfWork
            };
        }

        public IEnumerable<ShopEntity> Map(IEnumerable<Shop> arrayForMap)
        {
            if (arrayForMap == null) throw new ArgumentNullException();

            var mapresult = new List<ShopEntity>();
            foreach (var shop in arrayForMap)
            {
                mapresult.Add(Map(shop));
            }
            return mapresult;
        }
    }
}
