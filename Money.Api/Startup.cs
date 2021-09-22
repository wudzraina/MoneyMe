using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoneyMe.Application;
using MoneyMe.Insfrastracture;

namespace Money.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();
            services.AddControllersWithViews();
            services.AddOpenApiDocument(config =>
            {
                config.Title = "Money Me App APIP";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) => {

                await next();
                if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value)) {
                    //context.Request.Path = "/index.html";
                    context.Request.Path = "/swagger/index.html";
                    await next();
                }
            });

            app.UseDefaultFiles();
            app.UseStaticFiles();


            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        //private Func<RequestDelegate, RequestDelegate> async()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
