using Autofac;
using Autofac.Extras.DynamicProxy;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Util;

namespace IOCWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ////autofac(自动注册)
            //var builder = new ContainerBuilder();
            ////注册控制器
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            ////反射获取程序集
            //Assembly serAss = Assembly.Load("Services");
            ////在列表中注册类型(实例化)
            ////AsImplementedInterfaces:指定已扫描程序集的类型注册为提供其所有实现接口。
            ////InstancePerLifetimeScope: 配置组件，以便在单个ILifetimeScope中Resolver()的每个依赖组件或调用都获得相同的共享实例。不同生存期范围内的依赖组件将获得不同的实例。
            //builder.RegisterTypes(serAss.GetTypes()).AsImplementedInterfaces().InstancePerLifetimeScope();
            //var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //autofac
            var builder = new ContainerBuilder();
            builder.Register(c => new LoggingInterceptor());
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            Assembly serAss = Assembly.Load("Services");
            //EnableInterfaceInterceptors:在目标类型上启用接口拦截。拦截器将通过类或接口上的拦截属性确定，或者使用InterceptedBy()调用添加拦截器。
            builder.RegisterTypes(serAss.GetTypes()).AsImplementedInterfaces()
             .EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            #region autofac 手动注册(配置文件,两种配置方式，见web.config)
            //var builder = new ContainerBuilder();
            ////注册控制器
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            ////注册需要DI的模型绑定器
            //builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            ////注册Autofac.Integration.Mvc.AutofacModelBinderProvider。
            //builder.RegisterModelBinderProvider();
            ////注册像HttmpContextBase这样的web抽象
            //builder.RegisterModule<AutofacWebTypesModule>();
            ////向容器中添加模块。
            //builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            ////在视图页面中启用属性注入
            //builder.RegisterSource(new ViewRegistrationSource());
            ////启用动作过滤器中的属性注入。
            //builder.RegisterFilterProvider();
            ////使用已进行的组件注册创建一个新容器。
            //var container = builder.Build();
            ////使用指定的依赖关系解析程序接口，为依赖关系解析程序提供一个注册点。
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #endregion

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
