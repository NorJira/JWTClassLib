using System.ComponentModel.DataAnnotations;

namespace JWTClassLib.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}