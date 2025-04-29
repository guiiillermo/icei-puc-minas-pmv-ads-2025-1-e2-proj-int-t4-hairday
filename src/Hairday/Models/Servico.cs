// Modelo Cliente
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
// Modelo Servico
public class Servico
{
    [Key]
    public int id_servico { get; set; }

    [Required, MaxLength(100)]
    public string nome_servico { get; set; }

    [Required]
    public decimal preco { get; set; }

    [Required, ForeignKey("barbearia")]
    public string CNPJ_barbearia { get; set; }

    [Required, ForeignKey("barbeiro")]
    public string CPF_barbeiro { get; set; }

    public Barbearia barbearia { get; set; }
    public Barbeiro barbeiro { get; set; }
    public ICollection<Agendamento_Servico> agendamento_servicos { get; set; }
}
