using System.ComponentModel.DataAnnotations;

namespace JWTClassLib.Models.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}