// Modelo Cliente
// Modelo Agendamento_Servico

namespace Hairday.Models
{
    public class Agendamento_Servico
    {
        public int id_agendamento { get; set; }
        public int id_servico { get; set; }

        public Agendamento agendamento { get; set; }
        public Servico servico { get; set; }
    }
}