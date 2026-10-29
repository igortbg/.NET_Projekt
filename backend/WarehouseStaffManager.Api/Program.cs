using WarehouseStaffManager.Api.Data;
using WarehouseStaffManager.Api.Data.Migrations;

DotNetEnv.Env.TraversePath().Load();

var builder = WebApplication.CreateBuilder(args);


var ConnString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddNpgsql<WarehouseStaffManagerContext>(ConnString);

var app = builder.Build();

app.MigrateDb();

app.Run();
