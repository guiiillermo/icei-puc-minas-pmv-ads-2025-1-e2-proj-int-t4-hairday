namespace Hairday.ViewModels
{
    using Hairday.Models;
    using System.Collections.Generic;
    public class EscolhaServicoViewModel
    {
        public Barbearia Barbearia { get; set; }
        public List<Barbeiro> Barbeiros { get; set; }
    }
}
