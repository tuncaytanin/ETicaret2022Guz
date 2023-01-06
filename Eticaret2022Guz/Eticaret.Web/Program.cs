using Autofac;
using Autofac.Extensions.DependencyInjection;
using Eticaret.Web.Modules;
using Eticaret.Web.Services;
using ETicaret.DataAccesLayer.Concretes.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"), x =>
    {
        x.MigrationsAssembly(Assembly.GetAssembly(typeof(ApplicationDbContext)).GetName().Name);
    });
});



builder.Services.AddHttpClient<CategoryApiService>(opt =>
{
    opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]); 
});


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder=> containerBuilder.RegisterModule(new RepoServiceModule()));


var app = builder.Build();






/*
             // Hangi SqL ba?lanaca??m? bildirmem gerekiyor
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer("Data Source=TANINPC;database=DbETradeMvc22-23-Guz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", options => options.MigrationsAssembly("ETicaret.DataAccessLayer").MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo")));
 */
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
