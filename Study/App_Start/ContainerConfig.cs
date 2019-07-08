using Autofac;
using Autofac.Integration.Mvc;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Study.IService;
using System.Web.Compilation;
using System.IO;
using System;

namespace Study
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            //获取IAutoInject的Type
            var baseType = typeof(IAutoInject);
            //获取所有程序集
            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToList();
            //自动注册接口
            builder.RegisterAssemblyTypes(assemblies.ToArray()).Where(b => b.GetInterfaces().
            Any(c => c == baseType && b != baseType)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //自动注册控制器
            builder.RegisterControllers(assemblies.ToArray());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialise()
        {
            var builder = new ContainerBuilder();

            var baseType = typeof(IAutoInject);

            //扫描IService和Service相关的程序集

            var assemblys = BuildManager.GetReferencedAssemblies().Cast<Assembly>()
                .Where(m => m.FullName.Contains("Service")).ToList();

            //builder.RegisterControllers(assemblys.ToArray()).PropertiesAutowired();
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            //自动注入            
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(t => baseType.IsAssignableFrom(t) && t.IsClass)
              .AsImplementedInterfaces().InstancePerLifetimeScope();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(t => baseType.IsAssignableFrom(t) && t.IsClass)
              .AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        
    }
}