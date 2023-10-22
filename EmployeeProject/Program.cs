using Employee.Shared.Mappings.Base;
using Employee.Shared.MongoDb;
using EmployeeProject.Database.Mapping;
using Employee.Shared.Mappings.Base;
using Employee.Infrastructure;
using EmployeeProject.Service.Interface;
using EmployeeProject.Service;
using System.Reflection;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
BsonClassMapHelper.Register<UserMapping>();
builder.Services.AddSharedModule();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
//builder.Services.AddMediatR(typeof(UnitOfWork).Assembly);
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
