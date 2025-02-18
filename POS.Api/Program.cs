using Microsoft.Extensions.Configuration;
using POS.Infraestructure.Extensions;
using POS.Application.Extensions;

namespace POS.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var Configuration = builder.Configuration;

            builder.Services.addInjectionInfraestructure(Configuration);//Inyectar servicio de Extencion
            builder.Services.addInjectionApplication(Configuration);//Inyectar servicio de Extencion

            builder.Services.AddControllers();       
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
