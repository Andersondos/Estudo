using SRP_Fatura.Api.Repositorys;
using SRP_Fatura.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Adicionando os serviços ao contêiner de injeção de dependências
builder.Services.AddScoped<FaturaRepository>();
builder.Services.AddScoped<EmailService>();
builder.Services.AddScoped<SmsService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<FaturaService>();
// Add services to the container.

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
