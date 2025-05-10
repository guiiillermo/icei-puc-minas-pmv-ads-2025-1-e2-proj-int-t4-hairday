namespace Hairday.ViewModels;
using System.ComponentModel.DataAnnotations;

public class HorarioDisponivelViewModel
{
    [Required]
    public string CPF_barbeiro { get; set; }

    [Required]
    public List<DayOfWeek> DiasSelecionados { get; set; } = new();

    [Required]
    public List<string> HorariosSelecionados { get; set; } = new();
}

