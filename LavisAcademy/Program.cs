using LavisAcademy.DataAccess;
using LavisAcademy.Repositories;
using LavisAcademy.Repositories.Interfaces;
using LavisAcademy.Service;
using LavisAcademy.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddScoped<IAboutUsService, AboutUsService>();
builder.Services.AddScoped<IAboutRepository, AboutRepository>();

builder.Services.AddScoped<IPeriodService, PeriodService>();
builder.Services.AddScoped<IPeriodRepository, PeriodRepository>();

builder.Services.AddScoped<IEducationCoachService, EducationCoachService>();
builder.Services.AddScoped<IEducationCoachRepository, EducationCoachRepository>();



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
