using System;

namespace DoutorAgendaServices.Models
{
    public class UsuarioModel : BaseModel
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public DateTime? UltimoLogin { get; set; }

    }
}
