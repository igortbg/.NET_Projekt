using System.ComponentModel.DataAnnotations;

namespace WarehouseStaffManager.Api.DTOs.ShiftsDTOs;

public record class CreateShiftsDTO
(
    [Required(ErrorMessage = "Id użytkownika jest wymagane.")]
    [Range(1, int.MaxValue, ErrorMessage = "Id użytkownika musi być większe od 0.")]
    int UserId,

    [Required(ErrorMessage = "Czas rozpoczęcia zmiany jest wymagany.")]
    DateTime StartTime,
    
    [Required(ErrorMessage = "Czas zakończenia zmiany jest wymagany.")]
    DateTime EndTime
);
