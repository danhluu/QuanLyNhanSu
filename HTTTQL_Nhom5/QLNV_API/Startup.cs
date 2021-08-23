using Common.Data.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using QLNV_Application;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace QLNV_API
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
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsetting.json")
            //    .Build();

            //var connectionString = configuration.GetConnectionString("QuanLyNhanVienDb");

            //services.AddControllersWithViews();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "QLNV_API", Version = "v1" });
            });

            //cors
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            //Chu cai dau viet hoa json
            services
                .AddMvc()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });

            services.AddDbContext<QLNVDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("QuanLyNhanVienDb")));


            //Add DI
            services.AddTransient(typeof(IBaseDL<>), typeof(BaseDL<>));
            services.AddTransient<IBacLuongDL, BacLuongDL>();
            services.AddTransient<IBangCapDL, BangCapDL>();
            services.AddTransient<IChiTietHopDongDL, ChiTietHopDongDL>();
            services.AddTransient<IChiTietKhoaDaoTaoDL, ChiTietKhoaDaoTaoDL>();
            services.AddTransient<IChucVuDL, ChucVuDL>();
            services.AddTransient<IDonXinDL, DonXinDL>();
            services.AddTransient<IHopDongDL, HopDongDL>();
            services.AddTransient<IHoSoNhanVienDL, HoSoNhanVienDL>();
            services.AddTransient<IKhoaDaoTaoDL, KhoaDaoTaoDL>();
            services.AddTransient<ILuongDL, LuongDL>();
            services.AddTransient<INhanVienDL, NhanVienDL>();
            services.AddTransient<IPhongBanDL, PhongBanDL>();
            services.AddTransient<IPhuCapDL, PhuCapDL>();
            services.AddTransient<IQuanLyDL, QuanLyDL>();
            services.AddTransient<IQuyetDinhBoNhiemDL, QuyetDinhBoNhiemDL>();
            services.AddTransient<IPhongBanNhanVienDL, PhongBanNhanVienDL>();

            services.AddTransient<IThuongDL, ThuongDL>();
            
            
            services.AddTransient<ILoginDL, LoginDL>();
            
            
            //services.AddControllersWithViews()
            //    .AddNewtonsoftJson(options =>
            //    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //);

            //services.AddScoped<IThuongDL, ThuongDL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "QLNV_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
