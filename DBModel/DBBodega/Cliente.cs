using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Cliente
{
    public int CodigoCliente { get; set; }

    public int CodigoPersona { get; set; }

    public string DetallePerfil { get; set; } = null!;

    public virtual Persona CodigoPersonaNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
