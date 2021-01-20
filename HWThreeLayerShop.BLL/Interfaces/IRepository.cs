using System;
using System.Collections.Generic;
using System.Text;
using HWThreeLayerShop.BLL.Models;

namespace HWThreeLayerShop.BLL.Interfaces
{
    public interface IRepository
    {        
        public List<GoodDTO> GetGoodDTOsByCataligId(int id);
        public List<CatalogDTO> GetAllCatalogDTOs();
    }
}
