using AS32.Domain.Base;

namespace AS32.Domain.Faturamento.Cadastro
{
    public class Entidade : EntityBase
    {
        public string NomeCompleto { get; set; }
        public string Nome { get => GetName(); set { } }
        public string SobreNome { get => GetSobreNome(); set { } }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }

        private string GetName()
            => NomeCompleto.IndexOf(' ') != 0 ? NomeCompleto.Split()[0] : NomeCompleto;

        private string GetSobreNome()
            => NomeCompleto.IndexOf(' ') != 0 ? NomeCompleto.Split()[1] : NomeCompleto;
    }
}