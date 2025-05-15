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

        [Required]
        public string cidade { get; set; }

        [Required]
        public string telefone { get; set; }

        [Required, MaxLength(200)]
        public string endereco { get; set; }

        public ICollection<Barbeiro> barbeiros { get; set; }
        public ICollection<Servico> servicos { get; set; }
        public ICollection<Agendamento> agendamentos { get; set; }
    }
}