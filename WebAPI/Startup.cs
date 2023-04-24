using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAboutUsService, AboutUsManager>();
            services.AddSingleton<IAboutUsDal, AboutUsDal>();

            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<ICategoryDal, CategoryDal>();

            services.AddSingleton<IContactFormService, ContactFormManager>();
            services.AddSingleton<IContactFormDal, ContactFormDal>();

            services.AddSingleton<IContactInformationService, ContactInformationManager>();
            services.AddSingleton<IContactInformationDal, ContactInformationDal>();

            services.AddSingleton<IFeaturesService, FeaturesManager>();
            services.AddSingleton<IFeaturesDal, FeaturesDal>();

            services.AddSingleton<IImageService, ImageManager>();
            services.AddSingleton<IImageDal, ImageDal>();

            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IProductDal, ProductDal>();

            services.AddSingleton<IRequestFeatureService, RequestFeatureManager>();
            services.AddSingleton<IFeaturesDal, FeaturesDal>();

            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, UserDal>();

        }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPP v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(x => x
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyMethod()
                    .AllowAnyOrigin()
            );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

