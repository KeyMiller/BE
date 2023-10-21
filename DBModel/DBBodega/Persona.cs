using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Persona
{
    public int CodigoPersona { get; set; }

    public int CodigoDocumento { get; set; }

    public int CodigoDireccion { get; set; }

    public string Nombres { get; set; } = null!;

    public string ApPaterno { get; set; } = null!;

    public string ApMaterno { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string Usuario { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;

    public string? Celular { get; set; }

    public ulong Cargo { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Direccione CodigoDireccionNavigation { get; set; } = null!;

    public virtual Tipodocumento CodigoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<Colaborativo> Colaborativos { get; set; } = new List<Colaborativo>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
