using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HairDay.Models
{
    public class Horario_Disponivel
    {
        [Key]
        public int id_horario { get; set; }

        [Required, ForeignKey("barbeiro")]
        public string CPF_barbeiro { get; set; }

        public DateTime data { get; set; }
        public TimeSpan hora { get; set; }

        public bool ocupado { get; set; }
        public int? id_agendamento { get; set; }

        public Barbeiro barbeiro { get; set; }
        public Agendamento agendamento { get; set; }
    }
}
