namespace TeleimotBG.Web.Api.App_Start
{
    using System;
    using System.Web;
    using TeleimotBG.Data;
    using TeleimotBG.Data.Repositories;
    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;
    using Services.Data;

    public static class NinjectConfig
    {
        public static Action<IKernel> DependenciesRegistration = kernel =>
        {
            kernel.Bind<ITeleimotBGDbContext>().To<ITeleimotBGDbContext>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
        };

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<TeleimotBGDbContext>().To<TeleimotBGDbContext>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));

            kernel.Bind<IRealEstateService>().To<RealEstateService>();
            kernel.Bind<ICommentService>().To<CommentService>();
        }

        //private static void RegisterServices(IKernel kernel)
        //{
        //    DependenciesRegistration(kernel);

        //    kernel.Bind(b => b
        //        .From("TeleimotBG.Services.Data")
        //        .SelectAllClasses()
        //        .BindDefaultInterface());
        //}
    }
}