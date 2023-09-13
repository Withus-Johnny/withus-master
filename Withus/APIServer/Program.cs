using APIServer.Contexts;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using APIServer.Services.UserService;

namespace APIServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddDbContext<WithusContext>(
            options =>
            {
                options.ConfigureWarnings(warnings =>
                warnings.Log(CoreEventId.NavigationBaseIncludeIgnored));
                options.UseMySql(builder.Configuration.GetConnectionString("Develop"),
                new MySqlServerVersion(new Version()),
                builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                    builder.CommandTimeout(60);
                });
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddFilter((category, level) => level >= LogLevel.Warning)));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();
            app.Run();
        }
    }
}