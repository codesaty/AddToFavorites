using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToFavorites.Business.Notional;
using AddToFavorites.Business.Tangible;
using AddToFavorites.DataAccess.Notional;
using AddToFavorites.DataAccess.Tangible;
using AddToFavorites.MVC.UI.SessionServicies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AddToFavorites.MVC.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);//Projenin çalýþmasý için yapýlandýrdýk.//ÖNCE BURASI ÇALIÞIR.
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddSingleton<ILikeService, LikeManagerService>();
            services.AddSingleton<ILikeSessionServicies, LikeSessionServicies>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDistributedMemoryCache();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
