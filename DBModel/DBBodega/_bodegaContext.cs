using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBModel.DBBodega;

public partial class _bodegaContext : DbContext
{
    public _bodegaContext()
    {
    }

    public _bodegaContext(DbContextOptions<_bodegaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<Cargocolaborativo> Cargocolaborativos { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Colaborativo> Colaborativos { get; set; }

    public virtual DbSet<Comprobante> Comprobantes { get; set; }

    public virtual DbSet<Detallepedido> Detallepedidos { get; set; }

    public virtual DbSet<Direccione> Direcciones { get; set; }

    public virtual DbSet<Envio> Envios { get; set; }

    public virtual DbSet<Movimientocaja> Movimientocajas { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Subcategoria> Subcategorias { get; set; }

    public virtual DbSet<Tipodocumento> Tipodocumentos { get; set; }

    public virtual DbSet<Tipopago> Tipopagos { get; set; }

    public virtual DbSet<Unidadmedida> Unidadmedidas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=bodegayanin;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.HasKey(e => e.CodigoCaja).HasName("PRIMARY");

            entity.ToTable("cajas");

            entity.HasIndex(e => e.CodigoColaborativos, "CodigoColaborativos");

            entity.HasIndex(e => e.Codigopagos, "Codigopagos");

            entity.Property(e => e.CodigoCaja).HasColumnType("int(11)");
            entity.Property(e => e.CodigoColaborativos).HasColumnType("int(11)");
            entity.Property(e => e.Codigopagos).HasColumnType("int(11)");
            entity.Property(e => e.Estado)
                .HasColumnType("bit(1)")
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.MontoAdicional).HasPrecision(10, 2);
            entity.Property(e => e.MontoApertura).HasPrecision(10, 2);
            entity.Property(e => e.MontoCierre).HasPrecision(10, 2);
            entity.Property(e => e.UsuarioApertura).HasMaxLength(50);
            entity.Property(e => e.UsuarioCierre).HasMaxLength(50);

            entity.HasOne(d => d.CodigoColaborativosNavigation).WithMany(p => p.Cajas)
                .HasForeignKey(d => d.CodigoColaborativos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cajas_ibfk_1");

            entity.HasOne(d => d.CodigopagosNavigation).WithMany(p => p.Cajas)
                .HasForeignKey(d => d.Codigopagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cajas_ibfk_2");
        });

        modelBuilder.Entity<Cargocolaborativo>(entity =>
        {
            entity.HasKey(e => e.CodigoCargo).HasName("PRIMARY");

            entity.ToTable("cargocolaborativos");

            entity.Property(e => e.CodigoCargo).HasColumnType("int(11)");
            entity.Property(e => e.Funcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CodigoCategoria).HasName("PRIMARY");

            entity.ToTable("categorias");

            entity.HasIndex(e => e.Tipo, "Tipo").IsUnique();

            entity.Property(e => e.CodigoCategoria).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("b'1'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.Tipo).HasMaxLength(40);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.CodigoCliente).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.HasIndex(e => e.CodigoPersona, "CodigoPersona");

            entity.Property(e => e.CodigoCliente).HasColumnType("int(11)");
            entity.Property(e => e.CodigoPersona).HasColumnType("int(11)");
            entity.Property(e => e.DetallePerfil).HasMaxLength(70);

            entity.HasOne(d => d.CodigoPersonaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.CodigoPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientes_ibfk_1");
        });

        modelBuilder.Entity<Colaborativo>(entity =>
        {
            entity.HasKey(e => e.CodigoColaborativos).HasName("PRIMARY");

            entity.ToTable("colaborativos");

            entity.HasIndex(e => e.CodigoCargoColaborativos, "CodigoCargoColaborativos");

            entity.HasIndex(e => e.CodigoPersona, "CodigoPersona");

            entity.Property(e => e.CodigoColaborativos).HasColumnType("int(11)");
            entity.Property(e => e.CodigoCargoColaborativos).HasColumnType("int(11)");
            entity.Property(e => e.CodigoPersona).HasColumnType("int(11)");
            entity.Property(e => e.Experiencia).HasMaxLength(200);
            entity.Property(e => e.Foto).HasMaxLength(70);
            entity.Property(e => e.Usuario).HasMaxLength(70);

            entity.HasOne(d => d.CodigoCargoColaborativosNavigation).WithMany(p => p.Colaborativos)
                .HasForeignKey(d => d.CodigoCargoColaborativos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("colaborativos_ibfk_2");

            entity.HasOne(d => d.CodigoPersonaNavigation).WithMany(p => p.Colaborativos)
                .HasForeignKey(d => d.CodigoPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("colaborativos_ibfk_1");
        });

        modelBuilder.Entity<Comprobante>(entity =>
        {
            entity.HasKey(e => e.CodigoRecibo).HasName("PRIMARY");

            entity.ToTable("comprobantes");

            entity.Property(e => e.CodigoRecibo).HasColumnType("int(11)");
            entity.Property(e => e.Tipo).HasMaxLength(40);
        });

        modelBuilder.Entity<Detallepedido>(entity =>
        {
            entity.HasKey(e => e.CodigoDetallePedido).HasName("PRIMARY");

            entity.ToTable("detallepedidos");

            entity.HasIndex(e => e.CodigoPedido, "CodigoPedido");

            entity.Property(e => e.CodigoDetallePedido).HasColumnType("int(11)");
            entity.Property(e => e.CodigoPedido).HasColumnType("int(11)");
            entity.Property(e => e.PrecioTotal).HasPrecision(8, 2);
            entity.Property(e => e.PrecioUnitario).HasPrecision(8, 2);

            entity.HasOne(d => d.CodigoPedidoNavigation).WithMany(p => p.Detallepedidos)
                .HasForeignKey(d => d.CodigoPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallepedidos_ibfk_1");
        });

        modelBuilder.Entity<Direccione>(entity =>
        {
            entity.HasKey(e => e.CodigoDireccion).HasName("PRIMARY");

            entity.ToTable("direcciones");

            entity.Property(e => e.CodigoDireccion).HasColumnType("int(11)");
            entity.Property(e => e.Calle).HasMaxLength(40);
            entity.Property(e => e.Departamento).HasMaxLength(20);
            entity.Property(e => e.Distrito).HasMaxLength(20);
            entity.Property(e => e.Provincia).HasMaxLength(20);
            entity.Property(e => e.Referencia).HasMaxLength(150);
            entity.Property(e => e.Ubigeo).HasMaxLength(6);
            entity.Property(e => e.Urbanizacion)
                .HasMaxLength(150)
                .HasColumnName("urbanizacion");
        });

        modelBuilder.Entity<Envio>(entity =>
        {
            entity.HasKey(e => e.CodigoEnvio).HasName("PRIMARY");

            entity.ToTable("envios");

            entity.HasIndex(e => e.CodigoColaborativos, "CodigoColaborativos");

            entity.HasIndex(e => e.CodigoDireccion, "CodigoDireccion");

            entity.HasIndex(e => e.CodigoRecibo, "CodigoRecibo");

            entity.Property(e => e.CodigoEnvio).HasColumnType("int(11)");
            entity.Property(e => e.CodigoColaborativos).HasColumnType("int(11)");
            entity.Property(e => e.CodigoDireccion).HasColumnType("int(11)");
            entity.Property(e => e.CodigoRecibo).HasColumnType("int(11)");

            entity.HasOne(d => d.CodigoColaborativosNavigation).WithMany(p => p.Envios)
                .HasForeignKey(d => d.CodigoColaborativos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("envios_ibfk_3");

            entity.HasOne(d => d.CodigoDireccionNavigation).WithMany(p => p.Envios)
                .HasForeignKey(d => d.CodigoDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("envios_ibfk_2");

            entity.HasOne(d => d.CodigoReciboNavigation).WithMany(p => p.Envios)
                .HasForeignKey(d => d.CodigoRecibo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("envios_ibfk_1");
        });

        modelBuilder.Entity<Movimientocaja>(entity =>
        {
            entity.HasKey(e => e.CodigoMovimientoCaja).HasName("PRIMARY");

            entity.ToTable("movimientocajas");

            entity.HasIndex(e => e.CodigoCaja, "CodigoCaja");

            entity.HasIndex(e => e.CodigoDetallePedido, "CodigoDetallePedido");

            entity.Property(e => e.CodigoMovimientoCaja).HasColumnType("int(11)");
            entity.Property(e => e.CodigoCaja).HasColumnType("int(11)");
            entity.Property(e => e.CodigoDetallePedido).HasColumnType("int(11)");
            entity.Property(e => e.Monto).HasPrecision(10, 2);
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .HasColumnName("tipo");

            entity.HasOne(d => d.CodigoCajaNavigation).WithMany(p => p.Movimientocajas)
                .HasForeignKey(d => d.CodigoCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movimientocajas_ibfk_2");

            entity.HasOne(d => d.CodigoDetallePedidoNavigation).WithMany(p => p.Movimientocajas)
                .HasForeignKey(d => d.CodigoDetallePedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movimientocajas_ibfk_1");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.Codigopagos).HasName("PRIMARY");

            entity.ToTable("pagos");

            entity.HasIndex(e => e.CodigoTipopagos, "CodigoTipopagos");

            entity.Property(e => e.Codigopagos).HasColumnType("int(11)");
            entity.Property(e => e.CodigoTipopagos).HasColumnType("int(11)");
            entity.Property(e => e.Monto).HasPrecision(8, 2);

            entity.HasOne(d => d.CodigoTipopagosNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.CodigoTipopagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pagos_ibfk_1");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.CodigoPedido).HasName("PRIMARY");

            entity.ToTable("pedidos");

            entity.HasIndex(e => e.CodigoCliente, "CodigoCliente");

            entity.HasIndex(e => e.CodigoEnvio, "CodigoEnvio");

            entity.HasIndex(e => e.Codigopagos, "Codigopagos");

            entity.Property(e => e.CodigoPedido).HasColumnType("int(11)");
            entity.Property(e => e.CodigoCliente).HasColumnType("int(11)");
            entity.Property(e => e.CodigoEnvio).HasColumnType("int(11)");
            entity.Property(e => e.Codigopagos).HasColumnType("int(11)");
            entity.Property(e => e.EntregaPe).HasColumnType("datetime");
            entity.Property(e => e.RegistroPe).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pedidos_ibfk_1");

            entity.HasOne(d => d.CodigoEnvioNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoEnvio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pedidos_ibfk_2");

            entity.HasOne(d => d.CodigopagosNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.Codigopagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pedidos_ibfk_3");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.CodigoPersona).HasName("PRIMARY");

            entity.ToTable("personas");

            entity.HasIndex(e => e.CodigoDireccion, "CodigoDireccion");

            entity.HasIndex(e => e.CodigoDocumento, "CodigoDocumento");

            entity.HasIndex(e => e.Correo, "Correo").IsUnique();

            entity.HasIndex(e => e.Usuario, "Usuario").IsUnique();

            entity.Property(e => e.CodigoPersona).HasColumnType("int(11)");
            entity.Property(e => e.ApMaterno).HasMaxLength(60);
            entity.Property(e => e.ApPaterno).HasMaxLength(60);
            entity.Property(e => e.Cargo).HasColumnType("bit(1)");
            entity.Property(e => e.Celular).HasMaxLength(12);
            entity.Property(e => e.CodigoDireccion).HasColumnType("int(11)");
            entity.Property(e => e.CodigoDocumento).HasColumnType("int(11)");
            entity.Property(e => e.Contrasenia).HasMaxLength(10);
            entity.Property(e => e.Correo).HasMaxLength(60);
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Nombres).HasMaxLength(50);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Usuario).HasMaxLength(70);

            entity.HasOne(d => d.CodigoDireccionNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.CodigoDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personas_ibfk_2");

            entity.HasOne(d => d.CodigoDocumentoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.CodigoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personas_ibfk_1");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.CodigoProducto).HasName("PRIMARY");

            entity.ToTable("productos");

            entity.HasIndex(e => e.CodigoCategoria, "CodigoCategoria");

            entity.HasIndex(e => e.CodigoPedido, "CodigoPedido");

            entity.HasIndex(e => e.CodigoSubCategoria, "CodigoSubCategoria");

            entity.HasIndex(e => e.CodigoUnMedida, "CodigoUnMedida");

            entity.Property(e => e.CodigoProducto).HasColumnType("int(11)");
            entity.Property(e => e.CodigoCategoria).HasColumnType("int(11)");
            entity.Property(e => e.CodigoPedido).HasColumnType("int(11)");
            entity.Property(e => e.CodigoSubCategoria).HasColumnType("int(11)");
            entity.Property(e => e.CodigoUnMedida).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Imagen).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(70);
            entity.Property(e => e.Precio).HasPrecision(8, 2);
            entity.Property(e => e.Stock)
                .HasMaxLength(4)
                .IsFixedLength();

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CodigoCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productos_ibfk_2");

            entity.HasOne(d => d.CodigoPedidoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CodigoPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productos_ibfk_4");

            entity.HasOne(d => d.CodigoSubCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CodigoSubCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productos_ibfk_3");

            entity.HasOne(d => d.CodigoUnMedidaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CodigoUnMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productos_ibfk_1");
        });

        modelBuilder.Entity<Subcategoria>(entity =>
        {
            entity.HasKey(e => e.CodigoSubCategoria).HasName("PRIMARY");

            entity.ToTable("subcategorias");

            entity.HasIndex(e => e.CodigoCategoria, "CodigoCategoria");

            entity.HasIndex(e => e.Tipo, "Tipo").IsUnique();

            entity.Property(e => e.CodigoSubCategoria).HasColumnType("int(11)");
            entity.Property(e => e.CodigoCategoria).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("b'1'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.Tipo).HasMaxLength(40);

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.Subcategoria)
                .HasForeignKey(d => d.CodigoCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("subcategorias_ibfk_1");
        });

        modelBuilder.Entity<Tipodocumento>(entity =>
        {
            entity.HasKey(e => e.CodigoDocumento).HasName("PRIMARY");

            entity.ToTable("tipodocumentos");

            entity.Property(e => e.CodigoDocumento).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(40);
            entity.Property(e => e.Tipo).HasMaxLength(10);
        });

        modelBuilder.Entity<Tipopago>(entity =>
        {
            entity.HasKey(e => e.CodigoTipopagos).HasName("PRIMARY");

            entity.ToTable("tipopagos");

            entity.Property(e => e.CodigoTipopagos).HasColumnType("int(11)");
            entity.Property(e => e.Nombre).HasMaxLength(20);
        });

        modelBuilder.Entity<Unidadmedida>(entity =>
        {
            entity.HasKey(e => e.CodigoUnMedida).HasName("PRIMARY");

            entity.ToTable("unidadmedidas");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.CodigoUnMedida).HasColumnType("int(11)");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("b'1'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.Nombre).HasMaxLength(40);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.IdPersona, "id_persona");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasColumnType("bit(1)")
                .HasColumnName("estado");
            entity.Property(e => e.IdPersona)
                .HasColumnType("int(11)")
                .HasColumnName("id_persona");
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("username");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("usuario_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
