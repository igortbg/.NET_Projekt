using System.ComponentModel.DataAnnotations;

namespace WarehouseStaffManager.Api.DTOs.UsersDTOs;

public record class CreateUsersDTO
(
    string Login,
    string PasswordHash,
    string Role,
    string FirstName,
    string LastName,
    bool   HasForkliftLicense     

);