using Tinder.Application.UseCases;
using Tinder.Infrastructure.Settings;
using Tinder.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection(AppSettings.SectionName));

builder.Services.AddTransient<GetUsersUseCase>();
builder.Services.AddTransient<GetUserUseCase>();
builder.Services.AddTransient<AddUserUseCase>();
builder.Services.AddTransient<AddUserV2UseCase>();
builder.Services.AddServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
