using System;

namespace DoutorAgendaServices.Models
{
    public class AgendamentoModel : BaseModel
    {
        public MedicoModel Medico { get; set; }
        public DateTime DataHoraConsulta { get; set; }
        public PacienteModel Paciente { get; set; }
    }
}
