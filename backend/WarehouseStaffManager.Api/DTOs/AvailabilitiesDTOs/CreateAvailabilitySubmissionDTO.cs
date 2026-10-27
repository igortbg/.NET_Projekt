namespace WarehouseStaffManager.Api.DTOs.AvailabilitiesDTOs;

public record class CreateAvailabilitySubmissionDTO
(
    int UserId,
    string RawText
);
