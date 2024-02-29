using junBackend;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//dodavanje cors-a
builder.Services.AddCors(options => options.AddPolicy("myPolicy", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//konekcija sa bazom
builder.Services.AddDbContext<DbC>
    (option => { option.UseSqlServer(builder.Configuration.GetConnectionString("default")); });

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

app.UseCors("myPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
