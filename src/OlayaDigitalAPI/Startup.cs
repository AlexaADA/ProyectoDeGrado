using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OlayaDigital.Core.Intarfaces;
using OlayaDigital.Core.Service;
using OlayaDigital.Infrastructure.Data;
using OlayaDigital.Infrastructure.Filters;
using OlayaDigital.Infrastructure.Repositories;
using System;

namespace OlayaDigitalAPI
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
            services.AddControllers(options =>
            {
                //Se registra las excepciones globales
                options.Filters.Add<GlobalExceptionFilter>();
            });

            services.AddDbContext<db_OlayaDigitalContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("db_OlayaDigital")));

            //Configurando el servicio de automapper desde cualquier parte de la solucion (dominio)
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                //Ignorar el manejo de referencias circulares
                options.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<IPostRepository, PostRepository>();

            //Agragamos todos nuestros filtros de manera global
            services.AddMvc(options =>
            {
                options.Filters.Add<ValidationFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
