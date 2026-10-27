namespace WarehouseStaffManager.Api.DTOs.AvailibilitiesDTOs;

public record class CreateAvailabilitiesDTO
(
    int UserId,
    int SubmissionId,
    DateOnly Date,
    TimeOnly?   AvailableFrom,
    TimeOnly?   AvailableTo,
    bool IsAvailable
);