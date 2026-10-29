using System.ComponentModel.DataAnnotations;

namespace WarehouseStaffManager.Api.DTOs.UsersDTOs;

public record class UpdateUsersDTO
(
    [Required(ErrorMessage = "Login jest wymagany.")]
    [MaxLength(50, ErrorMessage = "Login nie może być dłuższy niż 50 znaków.")]
    string Login,

    [Required(ErrorMessage = "Hasło jest wymagane.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,100}$", 
            ErrorMessage = "Hasło musi mieć minimum 8 znaków, zawierać co najmniej jedną wielką literę, jedną małą literę, jedną cyfrę oraz jeden znak specjalny.")]
    string PasswordHash,

    [Required(ErrorMessage = "Rola jest wymagana.")]
    [AllowedValues("Worker", "Manager", ErrorMessage = "Dozwolone role to Worker i Manager")]
    string Role,

    [Required(ErrorMessage = "Imię jest wymagane.")]
    [MaxLength(50, ErrorMessage = "Imię nie może być dłuższy niż 50 znaków.")]
    string FirstName,

    [Required(ErrorMessage = "Nazwisko jest wymagane.")]
    [MaxLength(50, ErrorMessage = "Nazwisko nie może być dłuższy niż 50 znaków.")]

    string LastName,

    [Required(ErrorMessage = "Informacja o uprawnienaich na wózki widłowe jest wymagana.")]
    bool   HasForkliftLicense     

);