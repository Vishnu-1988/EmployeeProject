using Employee.Infrastructure.Service;
using Employee.Infrastructure.Service.Interface;
using Employee.Shared.MongoDb;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Security.Authentication;

namespace Employee.Infrastructure
{
    public static class SharedModule
    {
        public static IServiceCollection AddSharedModule(this IServiceCollection services)
        {
            services.TryAddSingleton(e =>
            {
                var cosmosDbOptions = e.GetService<IOptions<DatabaseSettings>>().Value;
                return GetMongoClient(cosmosDbOptions.ConnectionString);
            }); 
            services.TryAddScoped<IMongoCollectionService,MongoCollectionService>();
            return services;
        }

        private static IMongoClient GetMongoClient(string connectionString)
        {
            var settings=MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings
            {
               
                    EnabledSslProtocols = SslProtocols.Tls12
                
            };
            return new MongoClient(settings);
        }
    }
}