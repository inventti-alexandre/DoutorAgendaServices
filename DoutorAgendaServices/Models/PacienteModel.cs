using System.Collections.Generic;

namespace DoutorAgendaServices.Models
{
    public class PacienteModel : BaseModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public ICollection<AgendamentoModel> Agendamentos { get; set; }
    }
}
