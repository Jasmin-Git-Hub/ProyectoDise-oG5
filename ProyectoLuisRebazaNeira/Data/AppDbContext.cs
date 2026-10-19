using Microsoft.EntityFrameworkCore;
using ProyectoLuisRebazaNeira.Models;
using ProyectoLuisRebazaNeira.Models;

namespace ProyectoLuisRebazaNeira.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<HistorialSolicitud> HistorialSolicitudes { get; set; }
        public DbSet<RespuestaConsulta> RespuestaConsultas { get; set; }
        public DbSet<SolicitudAcademica> SolicitudAcademicas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. ROL — USUARIO (1:N)
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(u => u.IdRol)
                .OnDelete(DeleteBehavior.Restrict);

            // 2. USUARIO — CONSULTA (1:N)
            modelBuilder.Entity<Consulta>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.consultas)
                .HasForeignKey(c => c.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            // 3. CONSULTA — RESPUESTA_CONSULTA (1:N)
            modelBuilder.Entity<RespuestaConsulta>()
                .HasOne(rc => rc.Consulta)
                .WithMany(c => c.RespuestaConsultas)
                .HasForeignKey(rc => rc.IdConsulta)
                .OnDelete(DeleteBehavior.Cascade);

            // 4. USUARIO — RESPUESTA_CONSULTA (1:N)
            modelBuilder.Entity<RespuestaConsulta>()
                .HasOne(rc => rc.Usuario)
                .WithMany(u => u.respuestaConsultas)
                .HasForeignKey(rc => rc.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            // 5. USUARIO — SOLICITUD_ACADÉMICA (1:N)
            modelBuilder.Entity<SolicitudAcademica>()
                .HasOne(sa => sa.Usuario)
                .WithMany(u => u.solicitudAcademicas)
                .HasForeignKey(sa => sa.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            // 6. SOLICITUD_ACADÉMICA — HISTORIAL_SOLICITUD (1:N)
            modelBuilder.Entity<HistorialSolicitud>()
                .HasOne(hs => hs.solicitudAcademica)
                .WithMany(sa => sa.HistorialSolicitudes)
                .HasForeignKey(hs => hs.IdSolicitud)
                .OnDelete(DeleteBehavior.Cascade);

            // 7. USUARIO — HISTORIAL_SOLICITUD (1:N)
            modelBuilder.Entity<HistorialSolicitud>()
                .HasOne(hs => hs.Usuario)
                .WithMany(u => u.historialSolicitudes)
                .HasForeignKey(hs => hs.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rol>().HasData(
                new Rol { IdRol = 1, NombreRol = "Administrador" },
                new Rol { IdRol = 2, NombreRol = "Estudiante" }
            );
        }
    }
}
