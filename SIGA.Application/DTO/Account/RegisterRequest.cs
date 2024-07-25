﻿using System.ComponentModel.DataAnnotations;

namespace SIGA.Application.DTO.Account;
public sealed class RegisterRequest
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string FirstName { get; set; } = null!;
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string LastName { get; set; } = null!;
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Login { get; set; } = null!;
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string UserName { get; set; } = null!;
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Password { get; set; } = null!;
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [EmailAddress(ErrorMessage = "O campo {0} requer um e-mail válido")]
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [DataType(DataType.Date, ErrorMessage = "O campo {0} requer uma data válida")]
    public DateTime BirthDate { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public bool IsEmployed { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public bool IsProjectCoordinator { get; set; }

}