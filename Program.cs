using AutoMapper;
using SenaiApi.Contexto;
using SenaiApi.Repositorios;
using SenaiApi.Repositorios.Interfaces;
using SenaiApi.Servicos;
using SenaiApi.Servicos.Interface.cs;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<SenaiContext>();
            builder.Services.AddScoped<IEscolaService, EscolaServices>();
            builder.Services.AddScoped<IEscolaRepository, EscolaRepository>();
            builder.Services.AddScoped<IEnderecoService, EnderecoService>();
            builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            builder.Services.AddScoped<IProfessorService, ProfessorService>();
            builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();

            MapperConfiguration mapperConfiguration = new(mapperConfig => { mapperConfig.AddMaps(new[] { "SenaiApi" }); });
            builder.Services.AddSingleton(mapperConfiguration.CreateMapper());


            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
