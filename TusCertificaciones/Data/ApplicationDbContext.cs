using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TusCertificaciones.Models;
namespace TusCertificaciones.Data;

public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Certificaciones> Certificaciones { get; set; }
    public DbSet<EstadosCertificaciones> EstadosCertificaciones { get; set; }
    public DbSet<Estudiantes> Estudiantes { get; set; }

}