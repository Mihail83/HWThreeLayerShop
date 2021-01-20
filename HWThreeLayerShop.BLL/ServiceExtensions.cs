using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using HWThreeLayerShop.BLL.Interfaces;
using HWThreeLayerShop.BLL.BusinessLogic;

namespace HWThreeLayerShop.BLL
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterBLLServices(this IServiceCollection services)
        {            
            return services;
        }
    }
}
