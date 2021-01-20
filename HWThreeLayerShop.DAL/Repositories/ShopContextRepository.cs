using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HWThreeLayerShop.BLL.Interfaces;
using HWThreeLayerShop.BLL.Models;
using HWThreeLayerShop.DAL.EF;
using HWThreeLayerShop.DAL.Exeptions;


namespace HWThreeLayerShop.DAL.Repositories
{
    public class ShopContextRepository : IRepository
    {
        readonly ShopContext _context;
        public ShopContextRepository(ShopContext context) 
        {
            _context = context;
        }

        public List<CatalogDTO> GetAllCatalogDTOs()
        {
            var catalogs = _context.Catalogs.ToList();
            var catalogsList = new List<CatalogDTO>();
            if (catalogs != null && catalogs.Count()!=0)
            {
                catalogsList.AddRange(catalogs.Select(catalog => new CatalogDTO { Id = catalog.Id, Name = catalog.Name }));
            }
            else
            {
                throw new NotFoundExeption("Каталоги не обнаружены");
            }
            return catalogsList;
        }

        public List<GoodDTO> GetGoodDTOsByCataligId(int id)
        {
            List<GoodDTO> listGoodDTO = new List<GoodDTO>();
            var listGoodsByCatalogId = _context.Goods.Include("Catalogs").Where(p => p.Catalogs.Any(p=>p.Id==id)).ToList();

            if (listGoodsByCatalogId != null && listGoodsByCatalogId.Count()!=0)
            {
                listGoodDTO = listGoodsByCatalogId.Select(good => new GoodDTO(good.Id, good.Name, good.Price, good.Catalogs.Select(cat => cat.Id))).ToList<GoodDTO>();
            }
            else
            {
                throw new NotFoundExeption("Товары отсутствуют");
            }

            return listGoodDTO;
        }
    }
}
