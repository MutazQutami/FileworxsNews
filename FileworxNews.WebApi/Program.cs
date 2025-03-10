

using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Repos;
using FileworxNews.WebApi.Controllers;
using FileworxNews.WebApi.Registration;
using Microsoft.EntityFrameworkCore;


namespace FileworxNews.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var builder = WebApplication.CreateBuilder(args);

            builder.Services.RegisterServices();
            builder.Services.RegisterRepositories();
            builder.Services.ConfigureDatabase(builder.Configuration);
            builder.Services.AddScoped<IContentRepo, ContentRepo>();
            builder.Services.AddScoped<IContentQueryRepo, ContentQueryRepo>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
      
    }
}
