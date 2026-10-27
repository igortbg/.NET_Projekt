namespace WarehouseStaffManager.Api.DTOs;

public record class AvailabilitiesDTO
(
    int Id,
    int UserId,
    int SubmissionId,
    DateOnly Date,
    TimeOnly? AvailableFrom,
    TimeOnly? AvailableTo,
    bool IsAvailable
);
