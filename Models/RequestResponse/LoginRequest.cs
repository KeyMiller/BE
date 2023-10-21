using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class LoginRequest
    {
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string Username { get; set; } = "";
        [Required]
        [StringLength(300, MinimumLength = 6)]
        public string Password { get; set; } = "";
    }
}
