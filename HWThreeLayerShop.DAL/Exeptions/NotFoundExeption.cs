using System;
using System.Collections.Generic;
using System.Text;

namespace HWThreeLayerShop.DAL.Exeptions
{
    public class NotFoundExeption :Exception
    {
        public NotFoundExeption(string message) : base(message)
        { }
    }
}
