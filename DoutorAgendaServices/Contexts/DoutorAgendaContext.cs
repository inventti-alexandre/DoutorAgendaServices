using DoutorAgendaServices.Models;
using Microsoft.EntityFrameworkCore;

namespace DoutorAgendaServices.Contexts
{
    public class DoutorAgendaContext : DbContext
    {
        public DbSet<UsuarioModel> UsuarioTable { get; set; }
        public DbSet<PacienteModel> PacienteTable { get; set; }
        public DbSet<MedicoModel> MedicoTable { get; set; }
        public DbSet<AgendamentoModel> AgendamentoTable { get; set; }

        public DoutorAgendaContext(DbContextOptions<DoutorAgendaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
            modelBuilder.Entity<PacienteModel>().ToTable("Paciente");
            modelBuilder.Entity<MedicoModel>().ToTable("Medico");
            modelBuilder.Entity<AgendamentoModel>().ToTable("Agendamento");
        }
    }
}
