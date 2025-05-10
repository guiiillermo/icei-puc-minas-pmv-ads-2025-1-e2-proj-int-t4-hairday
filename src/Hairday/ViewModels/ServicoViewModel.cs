namespace Hairday.ViewModels;
public class ServicoSelecionadoViewModel
{
    public string NomeServico { get; set; }
    public bool Selecionado { get; set; }
    public decimal? Preco { get; set; }
}

public class ServicoFormViewModel
{
    public string CPF_barbeiro { get; set; }
    public string CNPJ_barbearia { get; set; }
    public List<ServicoSelecionadoViewModel> ServicosDisponiveis { get; set; }
}
