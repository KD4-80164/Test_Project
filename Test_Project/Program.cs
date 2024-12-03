using Enterprise.Services.Managers;
using Enterprise.Services.Managers.Interfaces;
using Enterprise.Services.Repositories;
using Enterprise.Services.Repositories.Interfaces;
using EnterpriseRepository.Entities.AppDBContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ApplicationDBContext>();
builder.Services.AddTransient<IDepartmentRepository,DepartmenetRepository>();
builder.Services.AddTransient<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddTransient<IEmployeeManager, EmployeeManager>();
builder.Services.AddTransient<IDepartmentManager, DepartmentManager>();



builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"),
        sqlOptions => sqlOptions.MigrationsAssembly("EnterpriseRepository")) // Set the migrations assembly here
);

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
