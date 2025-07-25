using System;
using System.ComponentModel.DataAnnotations;

namespace LRFrontend.Models;

public class LoginClass
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

}
