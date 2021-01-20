using System;
using System.Collections.Generic;
using System.Text;

namespace HWThreeLayerShop.BLL.Models
{
    public class GoodDTO
    {
        public GoodDTO()
        {
            CatalogsID = new List<int>();
        }
        public GoodDTO(int id, string name, decimal price, IEnumerable<int> catalogList) : this()
        {
            Id = id;
            Name = name;
            Price = price;
            CatalogsID.AddRange(catalogList);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<int> CatalogsID { get; set; }
    }
}
