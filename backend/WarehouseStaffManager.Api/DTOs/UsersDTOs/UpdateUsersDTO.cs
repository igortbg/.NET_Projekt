namespace WarehouseStaffManager.Api.DTOs.UsersDTOs;

public record class UpdateUsersDTO
(
    string Login,
    string PasswordHash,
    string Role,
    string FirstName,
    string LastName,
    bool   HasForkliftLicense     

);