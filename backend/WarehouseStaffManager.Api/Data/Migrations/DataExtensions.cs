using Microsoft.EntityFrameworkCore;

namespace WarehouseStaffManager.Api.Data.Migrations;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<WarehouseStaffManagerContext>();
        dbContext.Database.Migrate();
    }
}
