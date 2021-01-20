using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HWThreeLayerShop.BLL.Models;

namespace HWThreeLayerShop.WEB.Models
{
    public class CatalogViewModel
    {
        public CatalogViewModel() { }
        public CatalogViewModel(IEnumerable<CatalogDTO> catalogs, IEnumerable<GoodDTO> goods)
        {
            ListOfCatalog = catalogs;
            ListOfGood = goods;
        }
        public IEnumerable<CatalogDTO> ListOfCatalog { get; set; }
        public IEnumerable<GoodDTO> ListOfGood { get; set; }

    }
}
