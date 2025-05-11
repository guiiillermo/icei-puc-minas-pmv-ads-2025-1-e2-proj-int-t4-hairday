// Modelo Cliente
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hairday.Models;
// Modelo Agendamento
public class Agendamento
{
    [Key]
    public int id_agendamento { get; set; }

    [Required, ForeignKey("cliente")]
    public int id_cliente { get; set; }

    [Required, ForeignKey("barbeiro")]
    public string CPF_barbeiro { get; set; }

    [Required, ForeignKey("barbearia")]
    public string CNPJ_barbearia { get; set; }

    public DateTime data { get; set; }
    public TimeSpan hora { get; set; }

    public Cliente cliente { get; set; }
    public Barbeiro barbeiro { get; set; }
    public Barbearia barbearia { get; set; }
    public ICollection<Agendamento_Servico> agendamento_servicos { get; set; }
    public ICollection<Horario_Disponivel> horarios_disponiveis { get; set; }
}
