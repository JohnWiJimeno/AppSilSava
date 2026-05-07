using System;
using System.Collections.Generic;
using AppSilSava.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppSilSava.AccesoDatos.Models;

public partial class InfraCoreDbContext : DbContext
{
    public InfraCoreDbContext()
    {
    }

    public InfraCoreDbContext(DbContextOptions<InfraCoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accionistum> Accionista { get; set; }

    public virtual DbSet<AnalisisFinanciero> AnalisisFinancieros { get; set; }

    public virtual DbSet<AnalisisPuntuable> AnalisisPuntuables { get; set; }

    public virtual DbSet<AnalisisTecnico> AnalisisTecnicos { get; set; }

    public virtual DbSet<CapacidadTecnica5B> CapacidadTecnica5Bs { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<ContratoAporte> ContratoAportes { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EstadoContrato> EstadoContratos { get; set; }

    public virtual DbSet<InfoFinanciera> InfoFinancieras { get; set; }

    public virtual DbSet<Licitacion> Licitacions { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolPermiso> RolPermisos { get; set; }

    public virtual DbSet<SaldoContratosEjec5C> SaldoContratosEjec5Cs { get; set; }

    public virtual DbSet<TablaSalario> TablaSalarios { get; set; }

    public virtual DbSet<TipoEmpresa> TipoEmpresas { get; set; }

    public virtual DbSet<TipoObra> TipoObras { get; set; }

    public virtual DbSet<TipoPliego> TipoPliegos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accionistum>(entity =>
        {
            entity.HasKey(e => e.AccionistaId).HasName("PK_Accionista_1");

            entity.Property(e => e.AccionistaId).HasColumnName("AccionistaID");
            entity.Property(e => e.EmpresaAccionistaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaAccionistaID");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.NoAcciones)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PorcentajePart)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VrAccion)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.EmpresaAccionista).WithMany(p => p.AccionistumEmpresaAccionista)
                .HasForeignKey(d => d.EmpresaAccionistaId)
                .HasConstraintName("FK_Accionista_Empresas3");

            entity.HasOne(d => d.Empresa).WithMany(p => p.AccionistumEmpresas)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accionista_Empresas2");
        });

        modelBuilder.Entity<AnalisisFinanciero>(entity =>
        {
            entity.HasKey(e => e.AnalisisFinanId);

            entity.ToTable("AnalisisFinanciero");

            entity.Property(e => e.AnalisisFinanId).HasColumnName("AnalisisFinanID");
            entity.Property(e => e.CapitalTrabajo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");
            entity.Property(e => e.IndiceEndeudamiento).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IndiceLiquidez).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LicitacionId).HasColumnName("LicitacionID");
            entity.Property(e => e.Patrimonio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RazonCobertura).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RentaActivo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RentaPatrimonio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Empresa).WithMany(p => p.AnalisisFinancieros)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalisisFinanciero_Empresas");

            entity.HasOne(d => d.Indicador).WithMany(p => p.AnalisisFinancieros)
                .HasForeignKey(d => d.IndicadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalisisFinanciero_InfoFinanciera");

            entity.HasOne(d => d.Licitacion).WithMany(p => p.AnalisisFinancieros)
                .HasForeignKey(d => d.LicitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalisisFinanciero_Licitacion");
        });

        modelBuilder.Entity<AnalisisPuntuable>(entity =>
        {
            entity.HasKey(e => e.AnalisisPid);

            entity.ToTable("AnalisisPuntuable");

            entity.Property(e => e.AnalisisPid)
                .ValueGeneratedNever()
                .HasColumnName("AnalisisPID");
            entity.Property(e => e.Discapacitado).HasMaxLength(50);
            entity.Property(e => e.Emprendimiento).HasMaxLength(50);
            entity.Property(e => e.EmpresaId).HasColumnName("EmpresaID");
            entity.Property(e => e.LicitacionId).HasColumnName("LicitacionID");
            entity.Property(e => e.MiPyme).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Licitacion).WithMany(p => p.AnalisisPuntuables)
                .HasForeignKey(d => d.LicitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalisisPuntuable_Licitacion");
        });

        modelBuilder.Entity<AnalisisTecnico>(entity =>
        {
            entity.HasKey(e => e.AnalisisId);

            entity.ToTable("AnalisisTecnico");

            entity.Property(e => e.AnalisisId)
                .ValueGeneratedNever()
                .HasColumnName("AnalisisID");
            entity.Property(e => e.ContratoId).HasColumnName("ContratoID");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.LicitacionId).HasColumnName("LicitacionID");
            entity.Property(e => e.Observacion).HasMaxLength(500);

            entity.HasOne(d => d.Contrato).WithMany(p => p.AnalisisTecnicos)
                .HasForeignKey(d => d.ContratoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalisisTecnico_Contratos");

            entity.HasOne(d => d.Empresa).WithMany(p => p.AnalisisTecnicos)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalisisTecnico_Empresas");

            entity.HasOne(d => d.Licitacion).WithMany(p => p.AnalisisTecnicos)
                .HasForeignKey(d => d.LicitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalisisTecnico_Licitacion");
        });

        modelBuilder.Entity<CapacidadTecnica5B>(entity =>
        {
            entity.HasKey(e => e.CapacidadTecnicaId);

            entity.ToTable("CapacidadTecnica5B");

            entity.Property(e => e.CapacidadTecnicaId).HasColumnName("CapacidadTecnicaID");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.MatriculaProfesional).HasMaxLength(50);
            entity.Property(e => e.NoContrato).HasMaxLength(50);
            entity.Property(e => e.NombreProfesional).HasMaxLength(150);
            entity.Property(e => e.Profesion).HasMaxLength(100);

            entity.HasOne(d => d.Empresa).WithMany(p => p.CapacidadTecnica5Bs)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapacidadTecnica5B_Empresas");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.ToTable(tb =>
                {
                    
                    tb.HasTrigger("trg_Calcular_VrSmmlvPart2");
                });

            entity.Property(e => e.ContratoId).HasColumnName("ContratoID");
            entity.Property(e => e.Correo).HasMaxLength(80);
            entity.Property(e => e.DocumentoPdf).HasColumnName("DocumentoPDF");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.EntidadContratante).HasMaxLength(100);
            entity.Property(e => e.EstadoContratoId).HasColumnName("EstadoContratoID");
            entity.Property(e => e.NitConsorcioUt)
                .HasMaxLength(30)
                .HasColumnName("NitConsorcioUT");
            entity.Property(e => e.NoContrato).HasMaxLength(30);
            entity.Property(e => e.NombreContratista).HasMaxLength(100);
            entity.Property(e => e.Plataforma).HasMaxLength(100);
            entity.Property(e => e.Plazo).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorcentajePart).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Responsable).HasMaxLength(100);
            entity.Property(e => e.SalarioId).HasColumnName("SalarioID");
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.TipoObraId).HasColumnName("TipoObraID");
            entity.Property(e => e.ValorContrato).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VrSmmlv).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VrSmmlvPart).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VrTotalContrato).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Salario).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.SalarioId)
                .HasConstraintName("FK_Contratos_TablaSalarios");

            entity.HasOne(d => d.TipoObra).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.TipoObraId)
                .HasConstraintName("FK_Contratos_TipoObra");
        });

        modelBuilder.Entity<ContratoAporte>(entity =>
        {
            entity.HasKey(e => e.AporteId);

            entity.ToTable("ContratoAporte");

            entity.HasIndex(e => e.AccionistaId, "AccionistaID");

            entity.HasIndex(e => e.ContratoId, "ContratoID");

            entity.HasIndex(e => e.EmpresaId, "EmpresaID");

            entity.Property(e => e.AporteId).HasColumnName("AporteID");
            entity.Property(e => e.AccionistaId).HasColumnName("AccionistaID");
            entity.Property(e => e.ContratoId).HasColumnName("ContratoID");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");

            entity.HasOne(d => d.Accionista).WithMany(p => p.ContratoAportes)
                .HasForeignKey(d => d.AccionistaId)
                .HasConstraintName("FK_ContratoAporte_Accionista");

            entity.HasOne(d => d.Contrato).WithMany(p => p.ContratoAportes)
                .HasForeignKey(d => d.ContratoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratoAporte_Contratos");

            entity.HasOne(d => d.Empresa).WithMany(p => p.ContratoAportes)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_ContratoAporte_Empresas");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.Ciudad).HasMaxLength(50);
            entity.Property(e => e.Correo).HasMaxLength(50);
            entity.Property(e => e.Departamento).HasMaxLength(50);
            entity.Property(e => e.DireccionDomiclio).HasMaxLength(50);
            entity.Property(e => e.IdentificacionRf)
                .HasMaxLength(20)
                .HasColumnName("IdentificacionRF");
            entity.Property(e => e.IdentificacionRl)
                .HasMaxLength(20)
                .HasColumnName("IdentificacionRL");
            entity.Property(e => e.IdentificacionS).HasMaxLength(20);
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.MatriculaNo).HasMaxLength(20);
            entity.Property(e => e.NombreRepLegal).HasMaxLength(50);
            entity.Property(e => e.NombreSuplente).HasMaxLength(50);
            entity.Property(e => e.RevisorFiscal).HasMaxLength(50);
            entity.Property(e => e.Sigla).HasMaxLength(50);
            entity.Property(e => e.TamanoEmpresa).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.TipoEmpresaId).HasColumnName("TipoEmpresaID");

            entity.HasOne(d => d.TipoEmpresa).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.TipoEmpresaId)
                .HasConstraintName("FK_Empresas_TipoEmpresa");
        });

        modelBuilder.Entity<EstadoContrato>(entity =>
        {
            entity.ToTable("EstadoContrato");

            entity.Property(e => e.EstadoContratoId).HasColumnName("EstadoContratoID");
            entity.Property(e => e.Codigo).HasMaxLength(35);
            entity.Property(e => e.Descripcion).HasMaxLength(150);
        });

        modelBuilder.Entity<InfoFinanciera>(entity =>
        {
            entity.HasKey(e => e.IndicadorId);

            entity.ToTable("InfoFinanciera");

            entity.HasIndex(e => new { e.EmpresaId, e.AnioFiscal }, "IX_InfoFinanciera").IsUnique();

            entity.Property(e => e.IndicadorId).HasColumnName("IndicadorID");
            entity.Property(e => e.ActivoCorriente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActivoTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CapitalTrabajo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.GastosInteres).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IndiceEndeudamiento).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IndiceLiquidez).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IngresosOperacionales).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PasivoCorriente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PasivoTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Patrimonio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RazonCobertura).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RentaActivo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RentaPatrimonio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UtilidadPerdida).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Empresa).WithMany(p => p.InfoFinancieras)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InfoFinanciera_Empresas");
        });

        modelBuilder.Entity<Licitacion>(entity =>
        {
            entity.ToTable("Licitacion");

            entity.HasIndex(e => e.TipoPliegoId, "IX_TipoPliegoID").IsUnique();

            entity.Property(e => e.LicitacionId).HasColumnName("LicitacionID");
            entity.Property(e => e.Anticipo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CapitalTrabajo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscapacitadoSmmlv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DiscapacitadoSMMLV");
            entity.Property(e => e.DiscapacitadoVr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DiscapacitadoVR");
            entity.Property(e => e.EstadoContratoId).HasColumnName("EstadoContratoID");
            entity.Property(e => e.FiftyExpSmmlv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FiftyExpSMMLV");
            entity.Property(e => e.FiftyExpValor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kresidual)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KResidual");
            entity.Property(e => e.NoProceso).HasMaxLength(20);
            entity.Property(e => e.Objeto).HasMaxLength(500);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.Patrimonio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RelacionCsmmlv)
                .HasComment("Relacion de contratos en salarios")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RelacionCSMMLV");
            entity.Property(e => e.RelacionCv)
                .HasComment("Aca se almacena la realacion de contratos si es el 75%, 120% o 150%  en salarios")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RelacionCV");
            entity.Property(e => e.Smmlv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SMMLV");
            entity.Property(e => e.TipoPliegoId).HasColumnName("TipoPliegoID");
            entity.Property(e => e.ValorProceso).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ValorSmmlv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValorSMMLV");

            entity.HasOne(d => d.EstadoContrato).WithMany(p => p.Licitacions)
                .HasForeignKey(d => d.EstadoContratoId)
                .HasConstraintName("FK_Licitacion_EstadoContrato");

            entity.HasOne(d => d.TipoPliego).WithOne(p => p.Licitacion)
                .HasForeignKey<Licitacion>(d => d.TipoPliegoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Licitacion_TipoPliego");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.ToTable("Permiso");

            entity.HasIndex(e => e.Codigo, "IX_Codigo").IsUnique();

            entity.Property(e => e.PermisoId).HasColumnName("PermisoID");
            entity.Property(e => e.Codigo).HasMaxLength(60);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Modulo).HasMaxLength(50);
            entity.Property(e => e.NombrePermiso).HasMaxLength(120);
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.ToTable("Rol");

            entity.HasIndex(e => e.NombreRol, "IX_NombreRol").IsUnique();

            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.NombreRol).HasMaxLength(50);
        });

        modelBuilder.Entity<RolPermiso>(entity =>
        {
            entity.ToTable("RolPermiso");

            entity.Property(e => e.RolPermisoId).HasColumnName("RolPermisoID");
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.PermisoId).HasColumnName("PermisoID");
            entity.Property(e => e.RolId).HasColumnName("RolID");

            entity.HasOne(d => d.Permiso).WithMany(p => p.RolPermisos)
                .HasForeignKey(d => d.PermisoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolPermiso_Permiso");

            entity.HasOne(d => d.Rol).WithMany(p => p.RolPermisos)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolPermiso_Rol");
        });

        modelBuilder.Entity<SaldoContratosEjec5C>(entity =>
        {
            entity.HasKey(e => e.Sceid).HasName("PK_SaldoContratosEjecucion");

            entity.ToTable("SaldoContratosEjec5C");

            entity.HasIndex(e => e.ContratoId, "IX_ContratoID");

            entity.Property(e => e.Sceid).HasColumnName("SCEID");
            entity.Property(e => e.ContratoId).HasColumnName("ContratoID");
            entity.Property(e => e.DiasEjecutados).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DiasXejecutar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DiasXEjecutar");
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.EstadoSce)
                .HasMaxLength(50)
                .HasColumnName("EstadoSCE");
            entity.Property(e => e.SaldoContratoEjec).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoDiarioContrato).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoPendienteEjec).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Contrato).WithMany(p => p.SaldoContratosEjec5Cs)
                .HasForeignKey(d => d.ContratoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaldoContratosEjec5C_Contratos");

            entity.HasOne(d => d.Empresa).WithMany(p => p.SaldoContratosEjec5Cs)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaldoContratosEjec5C_Empresas");
        });

        modelBuilder.Entity<TablaSalario>(entity =>
        {
            entity.HasKey(e => e.SalarioId);

            entity.Property(e => e.SalarioId).HasColumnName("SalarioID");
            entity.Property(e => e.VrSalario).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TipoEmpresa>(entity =>
        {
            entity.ToTable("TipoEmpresa");

            entity.Property(e => e.TipoEmpresaId).HasColumnName("TipoEmpresaID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<TipoObra>(entity =>
        {
            entity.ToTable("TipoObra");

            entity.Property(e => e.TipoObraId).HasColumnName("TipoObraID");
            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoPliego>(entity =>
        {
            entity.ToTable("TipoPliego");

            entity.Property(e => e.TipoPliegoId).HasColumnName("TipoPliegoID");
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.NombreTipoPliego).HasMaxLength(150);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");

            entity.HasIndex(e => new { e.NombreUsuario, e.Correo }, "IX_Usuario").IsUnique();

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.EmpresaId)
                .HasMaxLength(30)
                .HasColumnName("EmpresaID");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.NombreCompleto).HasMaxLength(150);
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.UltimoAcceso).HasColumnType("datetime");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Empresas");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
