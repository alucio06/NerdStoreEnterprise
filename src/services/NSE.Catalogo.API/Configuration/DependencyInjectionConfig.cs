﻿using NSE.Catalogo.API.Data;
using NSE.Catalogo.API.Data.Repositories;
using NSE.Catalogo.API.Models;

namespace NSE.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
