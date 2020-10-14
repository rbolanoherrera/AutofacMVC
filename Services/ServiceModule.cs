using Autofac;
using Repositories;

namespace Services
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // optional: chain ServiceModule with other modules for going deeper down in the architecture: 
            //builder.RegisterModule<RepositoryModule>();

            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            // ... register more services for that layer
        }

    }
}