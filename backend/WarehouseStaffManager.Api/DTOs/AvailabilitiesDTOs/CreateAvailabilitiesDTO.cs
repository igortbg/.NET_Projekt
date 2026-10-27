namespace WarehouseStaffManager.Api.DTOs.AvailibilitiesDTOs;

public record class CreateAvailabilitiesDTO
(
    int UserId,
    DateOnly Date,
    TimeOnly?   AvailableFrom,
    TimeOnly?   AvailableTo,
    bool IsAvailable,
    string OriginalMessage   
);