using ERPService.Enums;

namespace ERPService.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string SobreNomeNomeFantasia { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public string CpfCnpj { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

    }
}
