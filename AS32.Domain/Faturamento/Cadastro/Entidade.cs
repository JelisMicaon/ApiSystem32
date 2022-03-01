using AS32.Domain.Base;

namespace AS32.Domain.Faturamento.Cadastro
{
    public class Entidade : EntityBase
    {
        public string NomeCompleto { get; set; }
        public string Nome { get => NomeProp; set => NomeProp = value.Split(' ')[0]; }
        public string SobreNome { get => SobreNomeProp; set => SobreNomeProp = value.Split(' ')[1]; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        private string NomeProp { get; set; }
        private string SobreNomeProp { get; set; }
    }
}