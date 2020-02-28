using AutoMapper;
using Customer.Api.Mapper;
using Customer.Data.DataAccess;
using Customer.Data.Services;
using Customer.Data.Services.Impl;
using CustomerApp.Business.Services;
using CustomerApp.Business.Services.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Customer.Api
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
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped(_ => new CustomerDbContext());
            services.AddTransient<ICustomersRepository, CustomerRepository>();
            services.AddTransient<IOrdersRepository, OrdersRepository>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOrdersService,OrdersService>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
