

using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Repos;
using Microsoft.EntityFrameworkCore;


namespace FileworxNews.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            //DbContext Configuration
          

            builder.Services.AddScoped<IFileworxEntityRepo ,FileworxEntityRepo>();
            builder.Services.AddScoped<IfileworxEntityQueryRepo , FileworxEntityQReop>();
            builder.Services.AddScoped<IUserRepo , UserRepo>();
            builder.Services.AddDbContext<FileworxDbContext>(Options =>
            {
                Options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
