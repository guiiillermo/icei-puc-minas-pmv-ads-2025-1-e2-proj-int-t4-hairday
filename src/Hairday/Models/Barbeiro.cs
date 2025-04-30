// Modelo Cliente
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HairDay.Models;
// Modelo Barbeiro
public class Barbeiro
{
    [Key, StringLength(11)]
    public string CPF_barbeiro { get; set; }

    [Required, MaxLength(100)]
    public string nome { get; set; }

    [Required, EmailAddress]
    public string email { get; set; }

    [Required]
    public string senha { get; set; }

    public string cidade { get; set; }

    [Required, ForeignKey("barbearia")]
    public string CNPJ_barbearia { get; set; }

    public Barbearia barbearia { get; set; }
    public ICollection<Servico> servicos { get; set; }
    public ICollection<Agendamento> agendamentos { get; set; }
    public ICollection<Horario_Disponivel> horarios_disponiveis { get; set; }
}
