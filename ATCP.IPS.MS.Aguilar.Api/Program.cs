using ATCP.IPS.MS.Aguilar.Core.Exceptions;
using ATCP.IPS.MS.Aguilar.Core.Services.Contracts;
using ATCP.IPS.MS.Aguilar.Core.Services.Implementation;
using Microsoft.Extensions.Hosting;
using System.Security.Cryptography.X509Certificates;

namespace ATCP.IPS.MS.Aguilar.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<ICustomerService, CustomerService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseMiddleware<ExceptionHandler>();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}