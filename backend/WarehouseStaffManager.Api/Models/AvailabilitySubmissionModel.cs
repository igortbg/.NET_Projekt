using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseStaffManager.Api.Models;

public class AvailabilitySubmissionModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public UsersModel User { get; set; } = null!;
    public string RawText { get; set; } = string.Empty;
}
