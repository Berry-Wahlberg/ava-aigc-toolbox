using AIGenManager.Core.Application.Ports;
using AIGenManager.Infrastructure.Data;
using AIGenManager.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System;

namespace AIGenManager.Infrastructure
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Database context
            var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AIGenManager");
            Directory.CreateDirectory(appDataPath);
            var dbPath = Path.Combine(appDataPath, "aigenmanager.db");
            services.AddSingleton(new DatabaseContext(dbPath));
            
            // SQLite connection
            services.AddSingleton(sp =>
            {
                var dbContext = sp.GetRequiredService<DatabaseContext>();
                return dbContext.GetConnection();
            });

            // Repositories
            services.AddSingleton<IImageRepository, SQLiteImageRepository>();
            services.AddSingleton<IFolderRepository, SQLiteFolderRepository>();
            services.AddSingleton<ITagRepository, SQLiteTagRepository>();
            services.AddSingleton<IImageTagRepository, SQLiteImageTagRepository>();
            services.AddSingleton<IAlbumRepository, SQLiteAlbumRepository>();

            return services;
        }
    }
}