using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopWithAJAX.BLL.Interfaces;
using ShopWithAJAX.BLL.BusinessModel;
using ShopWithAJAX.WEB.Models;

namespace ShopWithAJAX.WEB.Mapper
{
    public class MapperFromShopToShopMinViewModel : IMapper<Shop, ShopMinViewModel>
    {
        public ShopMinViewModel Map(Shop dataForMap)
        {
            return new ShopMinViewModel
            {
                ShopId = dataForMap.ShopId,
                Name = dataForMap.Name,
                TimeOfWork = dataForMap.TimeOfWork
            };
        }

        public IEnumerable<ShopMinViewModel> Map(IEnumerable<Shop> arrayForMap)
        {
            if (arrayForMap == null) throw new ArgumentNullException();

            var mapresult = new List<ShopMinViewModel>();
            foreach (var shop in arrayForMap)
            {
                mapresult.Add(Map(shop));
            }
            return mapresult;            
        }
    }
}
