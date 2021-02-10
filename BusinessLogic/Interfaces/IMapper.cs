using System;
using System.Collections.Generic;
using System.Text;

namespace ShopWithAJAX.BLL.Interfaces
{
    public interface IMapper< Tin, Tout >
    {
        public Tout Map(Tin dataForMap);
        public IEnumerable< Tout> Map(IEnumerable<Tin>  dataForMap);

    }
}
