using System;
using System.ComponentModel.DataAnnotations;

namespace LRFrontend.Models;

public class RegisterClass
{
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string? ConfirmPassword { get; set; }

   
}
