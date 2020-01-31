using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Storage.Business.DTO.ProductDTO;
using Storage.Business.Products;
using Storage.DAL;
using Storage.DAL.Repository;

namespace Storage.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StorageContext>(options =>
            {
                options.UseNpgsql(Configuration["ConnectionString"]);
            });

            services.AddAutoMapper(typeof(Startup), typeof(ProductMapping));
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
           // services.AddControllers(opinols => opinols.Filters.Add<StorageExceptionFilter>());
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
