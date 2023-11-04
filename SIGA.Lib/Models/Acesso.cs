﻿using SIGA.Lib.Enums;

namespace SIGA.Lib.Models;
public class Acesso : ModelBase
{ 
    public string Login { get; set; } = string.Empty;
    public string Senha { get; set;} = string.Empty;
    public bool Expiracao { get; set; } = false;
    public DateTime? DataExpiracao { get; set; }
    public ETipoAcesso TipoAcesso { get; set; }
    
    public VPN VPN { get; set; } = new();
    public Projeto Projeto { get; set; } = new();

    public List<Funcionario> Funcionarios { get; set; } = new();
}
