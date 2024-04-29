using Microsoft.EntityFrameworkCore;

using AutoMapper;
using Room_Management_API.Application.Helper.ProjectProfiles;
using Room_Management_API.Infrastructure.RoomsInfrastructure;

using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain;
using Room_Management_API.Infrastructure.RoomsInfrastructure.RoomTypeInf;

using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;
using Room_Management_API.Application.RoomsApp.RoomStatusDomain;
using Room_Management_API.Infrastructure.RoomsInfrastructure.RoomStatusInf;

using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities;
using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain;
using Room_Management_API.Infrastructure.RoomsInfrastructure.RoomFacilitiesInf;

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
builder.Services.AddScoped<IRoomStatusService, RoomStatusService>();
builder.Services.AddScoped<IRoomStatusRepository, RoomStatusRepository>();
builder.Services.AddScoped<IRoomFacilitiesService, RoomFacilitiesService>();
builder.Services.AddScoped<IRoomFacilitiesRepository, RoomFacilitiesRepository>();

// Automapper
var mapperConfiguration = new MapperConfiguration(conf =>
{
    conf.AddProfile(typeof(MappingProfile));
});

var mapper = mapperConfiguration.CreateMapper();
builder.Services.AddSingleton(mapper);

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
