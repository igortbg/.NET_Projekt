namespace WarehouseStaffManager.Api.DTOs;

public record class ShiftsDTO
(
    int Id,
    int UserId,
    DateTime StartTime,
    DateTime EndTime
);
