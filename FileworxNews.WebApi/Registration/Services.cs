using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Repos;
using Microsoft.EntityFrameworkCore;

namespace FileworxNews.WebApi.Registration
{
    public static class BuilderExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddOpenApi();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IFileworxEntityRepo, FileworxEntityRepo>();
            services.AddScoped<IFileworxEntityQueryRepo, FileworxEntityQRepo>();

            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IUserQueryRepo, UserQueryRepo>();

            services.AddScoped<IContentRepo, ContentRepo>();
            services.AddScoped<IContentQueryRepo, ContentQueryRepo>();

            services.AddScoped<IPhotoQueryRepo, PhotoQueryRepo>();
            services.AddScoped<IPhotoRepo, PhotoRepo>();

            services.AddScoped<INewsQueryRepo, NewsQueryRepo>();
            services.AddScoped<INewsRepo, NewsRepo>();
        }

        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FileworxDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AppConnectionString")));
        }
    }

}
