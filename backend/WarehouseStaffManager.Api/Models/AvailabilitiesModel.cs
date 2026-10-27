using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseStaffManager.Api.Models;

public class AvailabilitiesModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public UsersModel User { get; set; } = null!;
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
    public TimeOnly? AvailableFrom { get; set; } = null;
    public TimeOnly? AvailableTo { get; set; } = null;
    public bool IsAvailable { get; set; } = true;
    public string OriginalMessage { get; set; } = string.Empty;

}
