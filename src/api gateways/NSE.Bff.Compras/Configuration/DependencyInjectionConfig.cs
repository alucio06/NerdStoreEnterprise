﻿using NSE.Bff.Compras.Extensions;
using NSE.Bff.Compras.Services;
using NSE.WebAPI.Core.Usuario;

namespace NSE.Bff.Compras.Configuration.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddTransient<HttpClientAuthorizationDelegatingHandler>();

            services.AddHttpClient<ICatalogoService, CatalogoService>()
                    .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>();
                    //.AddPolicyHandler(PollyExtensions.EsperarTentar())
                    //.AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));

            services.AddHttpClient<ICarrinhoService, CarrinhoService>()
               .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>();
            //.AddPolicyHandler(PollyExtensions.EsperarTentar())
            //.AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));

            services.AddHttpClient<IPedidoService, PedidoService>()
               .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>();
            //.AddPolicyHandler(PollyExtensions.EsperarTentar())
            //.AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));

            services.AddHttpClient<IPagamentoService, PagamentoService>()
               .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>();
            //.AddPolicyHandler(PollyExtensions.EsperarTentar())
            //.AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));

        }
    }
}