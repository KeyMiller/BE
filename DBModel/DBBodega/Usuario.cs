using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? IdPersona { get; set; }

    public ulong? Estado { get; set; }

    public virtual Persona? IdPersonaNavigation { get; set; }
}
