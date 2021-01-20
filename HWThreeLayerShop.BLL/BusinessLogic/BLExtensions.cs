using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using HWThreeLayerShop.BLL.Models;

namespace HWThreeLayerShop.BLL.BusinessLogic
{
    public static class BLExtensions
    {
        
        public static List<GoodDTO> GetDiscount(this List<GoodDTO> goodDTOs)
        {
           var goodDTOwithDiscount = new List<GoodDTO>();
           goodDTOwithDiscount.AddRange(goodDTOs);
           if (DateTime.Now.DayOfWeek==DayOfWeek.Wednesday)           
           for (int i=0; i< goodDTOs.Count(); i++)
                {
                    goodDTOwithDiscount[i].Price = goodDTOwithDiscount[i].Price - goodDTOwithDiscount[i].Price * 0.1m;
                }

            return goodDTOwithDiscount;
        }
    }
}
