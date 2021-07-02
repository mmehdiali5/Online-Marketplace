using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;
using Shopping_App.Models;
using Microsoft.AspNet.OData.Batch;

namespace Shopping_App
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
            services.AddControllers();
            services.AddRouting();
            services.AddOData();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<SHOPPING_APP_DBMDFContext>();
/*            services.AddCors(policy =>
            {
                policy.AddPolicy("CorsPolicy", opt => opt
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });
*/            services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("Open");
            app.UseEndpoints(endpoints =>
            {
                endpoints.EnableDependencyInjection();
                endpoints.Select().Filter().Expand();
                endpoints.MapControllers();
            });

            app.UseHttpsRedirection();

            app.UseMvc(b =>
            {
                b.Select().Expand().Filter().OrderBy().MaxTop(100).Count();
                b.MapODataServiceRoute("odata", "odata", GetEdmModel());
            });
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Address>("Address");
            builder.EntitySet<UserItem>("UserItem");
            builder.EntitySet<Customer>("Customer");
            builder.EntitySet<Seller>("Seller");
            builder.EntitySet<Category>("Category");
            builder.EntitySet<Color>("Color");
            builder.EntitySet<ColorItem>("ColorItem");
            builder.EntitySet<FeaturedItem>("FeaturedItem");
            builder.EntitySet<Image>("Image");
            builder.EntitySet<Review>("Review");
            builder.EntitySet<Item>("Item");
            return builder.GetEdmModel();
        }
    }
}