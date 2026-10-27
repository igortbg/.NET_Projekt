namespace WarehouseStaffManager.Api.DTOs.ShiftsDTOs;

public record class CreateShiftsDTO
(
    int UserId,
    DateTime StartTime,
    DateTime EndTime
);
