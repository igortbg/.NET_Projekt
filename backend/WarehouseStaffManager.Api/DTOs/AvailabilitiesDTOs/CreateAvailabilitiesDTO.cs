using System.ComponentModel.DataAnnotations;

namespace WarehouseStaffManager.Api.DTOs.AvailibilitiesDTOs;

public record class CreateAvailabilitiesDTO
(
    [Required(ErrorMessage = "Id użytkownika jest wymagane.")]
    [Range(1, int.MaxValue, ErrorMessage = "Id użytkownika musi być większe od 0.")]
    int UserId,

    [Required(ErrorMessage = "Id zgłoszenia jest wymagane.")]
    [Range(1,int.MaxValue, ErrorMessage = "Id zgłoszenia musi być większe od 0.")]
    int SubmissionId,

    [Required(ErrorMessage = "Data dyspozycyjności jest wymagana.")]
    DateOnly Date,

    TimeOnly?   AvailableFrom,
    TimeOnly?   AvailableTo,

    [Required(ErrorMessage = "Określenie dyspozycyjności jest wymagane.")]
    bool IsAvailable
);