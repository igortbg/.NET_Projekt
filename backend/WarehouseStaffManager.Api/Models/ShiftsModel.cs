using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseStaffManager.Api.Models;

public class ShiftsModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public UsersModel User { get; set; } = null!;   
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

}
