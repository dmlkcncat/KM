using Business.Abstract;
using Business.Concrete;
using Core.Services;
using Core.Settings;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace WebAPI
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public Startup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }

        public const string adminClientRoot = "client/admin";
        public const string userClientRoot = "client";


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "wwwroot";
            });

            services.AddSpaStaticFiles();

            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            var key = "D2E2fc3TH2HN5K6PbNluKFDJ6RJjSYS9mYsCMSKvnDGcSfnLXSioZB6IdfymCuG5";
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            //services.AddScoped<IJWTAuthenticationManager>(new JWTAuthenticationManager(key));
            services.AddSingleton<IJWTAuthenticationManager>(new JWTAuthenticationManager(key));


            services.AddScoped<IAboutUsService, AboutUsManager>();
            services.AddScoped<IAboutUsDal, AboutUsDal>();

            services.AddScoped<ICountersService, CountersManager>();
            services.AddScoped<ICountersDal, CountersDal>();

            services.AddScoped<ILastProjectService, LastProjectManager>();
            services.AddScoped<ILastProjectDal, LastProjectDal>();

            services.AddScoped<IProcessesService, ProcessesManager>();
            services.AddScoped<IProcessesDal, ProcessesDal>();

            services.AddScoped<IProcessesImagesService, ProcessesImagesManager>();
            services.AddScoped<IProcessesImagesDal, ProcessesImagesDal>();

            services.AddScoped<IProjectService, ProjectManager>();
            services.AddScoped<IProjectDal, ProjectDal>();

            services.AddScoped<IProjectStepsService, ProjectStepsManager>();
            services.AddScoped<IProjectStepsDal, ProjectStepsDal>();

            services.AddScoped<INewsService, NewsManager>();
            services.AddScoped<INewsDal, NewsDal>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, UserDal>();

            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddScoped<IMailService, MailService>();

            services.AddCors(opt => opt.AddDefaultPolicy(
                builder => builder.AllowAnyOrigin()
            ));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseSwagger();
            //    app.UseSwaggerUI(c =>
            //    {
            //        c.SwaggerEndpoint("./v1/swagger.json", "My API V1"); //originally "./swagger/v1/swagger.json"
            //    });
            //}

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger(c =>
                {
                    c.RouteTemplate = "/swagger/{documentName}/swagger.json";
                });
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseDefaultFiles();
            //app.UseSpaStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyMethod()
                    .AllowAnyOrigin()
            );

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
            });

            //app.UseSpa(spa => { });
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
        }
    }
}
