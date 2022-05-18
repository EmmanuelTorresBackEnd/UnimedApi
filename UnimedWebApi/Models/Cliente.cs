using System;

namespace UnimedWebApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public string NomeDaMae { get; set; }
        public string Endereco { get; set; }
        public int IdCarteirinha { get; set; }
        public string NomeDoPlano { get; set; }
        public bool Exames { get; set; }
    }
}
