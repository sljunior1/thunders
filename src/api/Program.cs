using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.Swagger;
using thunders.tasks.application.Services.Tarefas;
using thunders.tasks.domain.Interfaces;
using thunders.tasks.infra;
using thunders.tasks.infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ThundersTasksConnection") ?? 
    throw new InvalidOperationException("String de conexão não encontrada");

builder.Services.AddDbContext<ThundersDbContext>(opt => opt.UseSqlServer(connectionString, migration => migration.MigrationsAssembly("thunders.tasks.infra")));
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Thunders Tasks API", Version = "v1" });
});
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<ITarefaService, TarefaService>();

builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Thunders Tasks API V1");
    });
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
