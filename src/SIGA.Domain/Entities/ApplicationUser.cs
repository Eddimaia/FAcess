﻿using Financials.Domain.Entities.Common;
using SIGA.Domain.Entities;

namespace Financials.Domain.Entities;
public class ApplicationUser : Entity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Login { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime LastLoginDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public bool IsPhoneNumberConfirmed { get; set; }
    public bool IsEmployed { get; set; }
    public bool IsProjectCoordinator {  get; set; }



    public ICollection<Role> Roles { get; set; } = new List<Role>();
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}
