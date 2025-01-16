
using System.Threading.RateLimiting;
using WebFileManagement.Service.Services;
using WebFileManagement.StorageBroker.Services;

namespace WebFileManagement.Server
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

            builder.Services.AddScoped<IStorageService, StorageService>();
            builder.Services.AddSingleton<IStorageBrokerService, LocalStorageBrokerService>();
            //builder.Services.AddSingleton<IStorageBrokerService, AwsStorageService>();
            //builder.Services.AddSingleton<IStorageService, StorageService>();
            //builder.Services.AddTransient<IStorageService, StorageService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
