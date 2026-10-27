namespace WarehouseStaffManager.Api.Models;

public class UsersModel
{
    public int Id { get; set; }
    public string Login { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "Worker";
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public bool HasForkliftLicense { get; set; } = false;

    public List<AvailabilitiesModel> Availability { get; set; } = new();
    public List<ShiftsModel> Shifts { get; set; } = new();

}
