using Autofac;
using Eticaret.Core.Services;
using ETicaret.DataAccesLayer.EntityFrameWorks;
using ETicaret.DataAccesLayer.Repositories;
using Eticaret.Repositories;
using System.Reflection;
using Module = Autofac.Module;
using ETicaret.BussinessLayer.Concrete;

namespace Eticaret.Web.Modules
{
    public class RepoServiceModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            /*
                         services.AddScoped(typeof(IGenericDal<>), typeof(EfRepositoyBase<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));


            services.AddScoped<ICustomerDal, EfCustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IRolDal, EfRolRepository>();
            services.AddScoped<IRolService, RoleService>();
             */

            builder.RegisterGeneric(typeof(EfRepositoyBase<>)).As(typeof(IGenericDal<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var dalAssembley = Assembly.GetAssembly(typeof(EfCategoryRepository));
            var blAssembley = Assembly.GetAssembly(typeof(CategoryService));


            builder.RegisterAssemblyTypes(apiAssembly, dalAssembley, blAssembley).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, dalAssembley, blAssembley).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(apiAssembly, dalAssembley, blAssembley).Where(x => x.Name.EndsWith("ApiService")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
