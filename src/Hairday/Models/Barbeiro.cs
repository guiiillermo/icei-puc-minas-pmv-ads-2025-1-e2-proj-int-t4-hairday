// Modelo Cliente
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hairday.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
// Modelo Barbeiro
public class Barbeiro
{
    [Key, StringLength(14)]
    public string CPF_barbeiro { get; set; }

    [Required(ErrorMessage = "Obrigatorio informar o nome"), MaxLength(100), ]
    public string nome { get; set; }

    [Required(ErrorMessage = "Obrigatorio informar o email"), EmailAddress]
    public string email { get; set; }

    [Required(ErrorMessage = "Obrigatorio informar a senha")]
    public string senha { get; set; }

    [Required(ErrorMessage = "Obrigatorio informar a cidade")]
    public string cidade { get; set; }

    [Required(ErrorMessage = "Obrigatorio informar o CNPJ da barbearia"), ForeignKey("barbearia"), StringLength(18)]
    public string CNPJ_barbearia { get; set; }

    [ValidateNever]
    public Barbearia barbearia { get; set; }

    [ValidateNever]
    public ICollection<Servico> servicos { get; set; }

    [ValidateNever]
    public ICollection<Agendamento> agendamentos { get; set; }

    [ValidateNever]
    public ICollection<Horario_Disponivel> horarios_disponiveis { get; set; }
}
