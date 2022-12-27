
using Eticaret.Core.Services;
using Eticaret.Repositories;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.DataAccesLayer.Concretes.Contexts;
using ETicaret.DataAccesLayer.EntityFrameWorks;
using ETicaret.DataAccesLayer.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using System.Text;


namespace Eticaret.WepAPI
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
            // Hangi SqL ba?lanaca??m? bildirmem gerekiyor
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer("Data Source=TANINPC;database=DbETradeMvc22-23-Guz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", options => options.MigrationsAssembly("ETicaret.DataAccessLayer").MigrationsHistoryTable(HistoryRepository.DefaultTableName,"dbo")));

            services.AddControllers();
            #region Swagger

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Eticaret.WepAPI", Version = "v1" });

                // Swager Üzerinden Beare yetkilendirme butonu eklemeliyiz

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name="Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme ="Bearer",
                    BearerFormat ="JWT",
                    In=ParameterLocation.Header,
                    Description = "Bearer şeması kullan. JWT Yetkilendirme başlığı\r\n\r\n 'Bearer'[Boşluk] giriniz. Örnek : Bearer 1254545asa5d45a4"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id="Bearer"
                            } 
                        },
                        new string[]{}
                    }
                });
            });

            #endregion

            #region JWT

            //var applicationsSection = Configuration.GetSection("AppSettings");
            //services.Configure<AppSettings>(applicationsSection);
            //var appSettings = applicationsSection.Get<AppSettings>();
            //var key = Encoding.ASCII.GetBytes(appSettings.SecurityKey);

            //services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(x=> {
            //    x.RequireHttpsMetadata = false;
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };

            //});

            #endregion
            // Service ilk ayağa kalktığında varsayılan olarak oluşturulan classlar..
            services.AddScoped(typeof(IGenericDal<>),typeof(EfRepositoyBase<>));
            services.AddScoped(typeof(IService<>),typeof(Service<>));
            services.AddScoped<ICustomerDal, EfCustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IRolDal, EfRolRepository>();
            services.AddScoped<IRolService, RoleService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Eticaret.WepAPI v1"));
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
