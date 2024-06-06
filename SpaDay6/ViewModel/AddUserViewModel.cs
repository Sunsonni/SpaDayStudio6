using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModel;

public class AddUserViewModel
{
    [Required(ErrorMessage = "Username is required")]
    [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be 5 to 15 characters")]
    public string? Username { get; set;}

    [Required(ErrorMessage = "Password is required")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 characters")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Password verification is required")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 characters")]
    public string? VerifyPassword { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

}