using System.ComponentModel.DataAnnotations;

namespace WarehouseStaffManager.Api.DTOs.AvailabilitiesDTOs;

public record class CreateAvailabilitySubmissionDTO
(
    [Required(ErrorMessage = "Id użytkownika jest wymagane.")]
    [Range(1,int.MaxValue, ErrorMessage = "Id użytkownika musi być większe od 0.")]
    int UserId,

    [Required(ErrorMessage = "Treść zgłoszenia nie może być pusta.")]
    [MaxLength(500, ErrorMessage = "Wiadomość może mieć maksymalnie 500 znaków.")]
    string RawText
);
