using DoutorAgendaServices.Contexts;
using DoutorAgendaServices.Models;
using System.Linq;

namespace DoutorAgendaServices.Configuration
{
    public static class DbInitializer
    {

        public static void Initialize(DoutorAgendaContext context)
        {

            context.Database.EnsureCreated();

            if (!context.MedicoTable.Any())
            {
                var medicos = new MedicoModel[]
                {
                    new MedicoModel{Nome="Neymar Junior",CRM="123456",Especialidade="Clinico"},
                    new MedicoModel{Nome="Gabriel Jesus",CRM="654321",Especialidade="Otorrino"},
                    new MedicoModel{Nome="Tiago Silva",CRM="321654",Especialidade="Clinico"},
                    new MedicoModel{Nome="Daniel Alves",CRM="321456",Especialidade="Gastro"},
                    new MedicoModel{Nome="Ronaldo Fenomeno",CRM="456321",Especialidade="Clinico"}
                };
                context.MedicoTable.AddRange(medicos);
                context.SaveChanges();
            }

            if (!context.UsuarioTable.Any())
            {
                var usuarios = new UsuarioModel[]
                {
                    new UsuarioModel{Nome="Administrador",Login="admin"},
                    new UsuarioModel{Nome="Usuario Padrao",Login="padrao"},
                };
                context.UsuarioTable.AddRange(usuarios);
                context.SaveChanges();
            }

            if (!context.PacienteTable.Any())
            {
                var pacientes = new PacienteModel[]
                {
                    new PacienteModel{Nome="Paciente 1",Cpf="11111111111"},
                    new PacienteModel{Nome="Paciente 2",Cpf="22222222222"},
                };
                context.PacienteTable.AddRange(pacientes);
                context.SaveChanges();
            }

        }
    }
}
