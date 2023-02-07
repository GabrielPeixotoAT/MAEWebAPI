using MAEWebAPI.Context;
using MAEWebAPI.DIP;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string subjectConnection = builder.Configuration.GetConnectionString("SubjectConnection");

// Add services to the container.

//builder.Services.AddDbContext<SubjectContext>(opts => opts.UseSqlServer(subjectConnection));
builder.Services.AddDbContext<SubjectContext>(opts => opts.UseMySql(subjectConnection, ServerVersion.AutoDetect(subjectConnection)));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

new DIP(builder.Services);

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
