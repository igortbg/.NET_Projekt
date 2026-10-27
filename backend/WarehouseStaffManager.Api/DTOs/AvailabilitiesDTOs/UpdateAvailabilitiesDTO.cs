namespace WarehouseStaffManager.Api.DTOs.AvailibilitiesDTOs;

public record class UpdateAvailabilitiesDTO
(
    int UserId,
    DateOnly Date,
    TimeOnly?   AvailableFrom,
    TimeOnly?   AvailableTo,
    bool IsAvailable,
    string OriginalMessage   
);
