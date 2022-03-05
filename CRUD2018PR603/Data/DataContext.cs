using CRUD2018PR603.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD2018PR603.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options){}
    
    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<EstadosEquipo> EstadosEquipos { get; set; }
    public DbSet<TipoEquipo> TipoEquipos { get; set; }
}