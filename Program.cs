using Refit;
using Src.Core.Implementation;
using Src.Core.Interfaces;
using Src.Core.Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IViaCepIntegration, ViaCepIntegration>();

//Configuracao do Refit com a url que desejo
builder.Services.AddRefitClient<IViaCepIntegrationRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://viacep.com.br");
});

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
