
using Microsoft.EntityFrameworkCore;
using FinalProject.DataAccess.Concrete.EntityFramework.Contexts;
using FinalProject.Business.Autofac;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using FinalProject.Business.Abstract;
using FinalProject.Controllers;
using FinalProject.Business.Concrete;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*builder.Services.AddDbContext<DataContexts>(opt =>
	opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"))
);*/


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
	.ConfigureContainer<ContainerBuilder>(builder =>
	{
		builder.RegisterModule(new AutofacBussinessModule());
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
