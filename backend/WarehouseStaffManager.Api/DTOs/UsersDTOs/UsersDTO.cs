namespace WarehouseStaffManager.Api.DTOs;

public record class UsersDTO
(
    int Id,
    string Login,
    string PasswordHash,
    string Role,
    string FirstName,
    string LastName,
    bool HasForkliftLicense
);
