using System.ComponentModel.DataAnnotations;

namespace DoutorAgendaServices.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
