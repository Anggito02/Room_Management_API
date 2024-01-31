using Microsoft.EntityFrameworkCore;

using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain;

using Room_Management_API.Infrastructure;
using Room_Management_API.Infrastructure.RoomsInfrastructure.RoomTypeInf;
using Room_Management_API.Infrastructure.RoomsInfrastructure;

var builder = WebApplication.CreateBuilder(args);

// Register Configuration
ConfigurationManager configurationManager = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext - Rooms
builder.Services.AddDbContext<RoomsDbContext>(
    options => options.UseNpgsql(
        configurationManager.GetConnectionString("DefaultConnection"),
        migration => migration.MigrationsAssembly("Room_Management_API.Infrastructure")
    )
);

// Dependency Injection
builder.Services.AddScoped<IRoomTypeService, RoomTypeService>();
builder.Services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();

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
