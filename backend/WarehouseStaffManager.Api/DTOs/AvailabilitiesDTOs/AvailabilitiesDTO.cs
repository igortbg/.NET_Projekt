namespace WarehouseStaffManager.Api.DTOs;

public record class AvailabilitiesDTO
(
    int Id,
    int UserId,
    DateOnly Date,
    TimeOnly? AvailableFrom,
    TimeOnly? AvailableTo,
    bool IsAvailable,
    string OriginalMessage
);
