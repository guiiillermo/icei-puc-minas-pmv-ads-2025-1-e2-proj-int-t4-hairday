// Modelo Cliente
using System.ComponentModel.DataAnnotations;
// Modelo Barbearia

namespace Hairday.Models
{
    public class Barbearia
    {
        [Key, StringLength(14)]
        public string CNPJ_barbearia { get; set; }

        [Required, MaxLength(100)]
        public string nome { get; set; }
        [Required, EmailAddress]
        public string email { get; set; }

        [Required]
        public string senha { get; set; }

        public string cidade { get; set; }

        public string telefone { get; set; }

        public ICollection<Barbeiro> barbeiros { get; set; }
        public ICollection<Servico> servicos { get; set; }
        public ICollection<Agendamento> agendamentos { get; set; }
    }
}