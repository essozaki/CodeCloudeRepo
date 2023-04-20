﻿using System.ComponentModel.DataAnnotations;

namespace CodeCloude.Api.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
