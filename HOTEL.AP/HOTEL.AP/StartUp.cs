using HOTHOTEL.AP.Extensions;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Services;

namespace HOTEL.AP
{
    public class StartUp
    {
        public IConfiguration Configuration { get; }

        public StartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HOTEL.API", Version = "v1", });
                c.CustomSchemaIds(ShemaIdStrategy);
                c.OperationFilter<CustomFilters.AddHeaderFilter>();
            });
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddMvc();
            services.AddInfra(Configuration);
            services.AddServices(Configuration);
        }

        private string ShemaIdStrategy(Type currentClass)
        {
            return currentClass.Name.EndsWith("Model") ? currentClass.Name.Replace("Model", string.Empty) : currentClass.Name;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseDeveloperExceptionPage();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "HOTELS");
                c.InjectStylesheet("./swagger-ui/custom.css");
                c.RoutePrefix = string.Empty;
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
