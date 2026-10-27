namespace WarehouseStaffManager.Api.DTOs.AvailabilitiesDTOs;

public record class AvailabilitySubmissionDTO
(
    int Id,
    int UserId,
    string RawText
);
