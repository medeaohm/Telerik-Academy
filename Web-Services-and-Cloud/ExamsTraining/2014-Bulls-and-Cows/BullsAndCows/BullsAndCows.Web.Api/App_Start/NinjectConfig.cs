namespace BullsAndCows.Web.Api
{
    using System;
    using System.Web;
    using BullsAndCows.Data;
    using BullAndCows.Data.Repositories;
    using Ninject;
    using Ninject.Web.Common;
    using Services.Data;

    public static class NinjectConfig
    {
        public static Action<IKernel> DependenciesRegistration = kernel =>
        {
            kernel.Bind<IBullsAndCowsDbContext>().To<BullsAndCowsDbContext>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(EfGenericRepository<>));
        };

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

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
            kernel.Bind<BullsAndCowsDbContext>().To<BullsAndCowsDbContext>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(EfGenericRepository<>));

            kernel.Bind<IGameService>().To<GameService>();
        }
    }
}