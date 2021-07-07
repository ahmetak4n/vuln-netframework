using System.ComponentModel.DataAnnotations;

namespace vuln_netframework.Models.Login
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Message { get; set; }
    }
}