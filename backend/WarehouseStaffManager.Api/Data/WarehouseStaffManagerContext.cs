using Microsoft.EntityFrameworkCore;
using WarehouseStaffManager.Api.Models;

namespace WarehouseStaffManager.Api.Data;

public class WarehouseStaffManagerContext(DbContextOptions<WarehouseStaffManagerContext> options)
: DbContext(options)
{
    public DbSet<UsersModel> Users => Set<UsersModel>();
    public DbSet<ShiftsModel> Shifts => Set<ShiftsModel>();
    public DbSet<AvailabilitiesModel> Availabilities => Set<AvailabilitiesModel>();
    public DbSet<AvailabilitySubmissionModel> AvailabilitySubmission => Set<AvailabilitySubmissionModel>();
}
