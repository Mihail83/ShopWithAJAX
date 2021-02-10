using System;
using System.Collections.Generic;
using System.Text;
using ShopWithAJAX.Database.Repository;
using ShopWithAJAX.Database.Interfaces;
using ShopWithAJAX.BLL.Interfaces;
using ShopWithAJAX.BLL.Mapper;
using ShopWithAJAX.Database.EntityModel;
using ShopWithAJAX.BLL.BusinessModel;

namespace ShopWithAJAX.BLL.BusinessLogic
{
    public  class ShopSupplier
    {
        private readonly IShopRepository _shopRepository;
        private readonly IMapper<ShopEntity, Shop> _mapperToShop;
        public ShopSupplier(IShopRepository repository, IMapper<ShopEntity, Shop> mapper)
        {
            _shopRepository = repository;
            _mapperToShop = mapper;
        }

        public Shop GetShopById(int id)
        {
            return _mapperToShop.Map(_shopRepository.GetShopEntityById(id));
        }
        public IEnumerable<Shop> GetShops()
        {
            return _mapperToShop.Map(_shopRepository.GetShopEntities());
        }

    }
}
