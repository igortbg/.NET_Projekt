namespace WarehouseStaffManager.Api.DTOs.ShiftsDTOs;

public record class UpdateShiftsDTO
(
    int UserId,
    DateTime StartTime,
    DateTime EndTime
);
