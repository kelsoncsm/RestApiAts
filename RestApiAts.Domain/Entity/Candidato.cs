using System;
using System.Collections.Generic;

namespace RestApiAts.Domain.Entity
{
    public class Candidato : Base
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public string Cpf { get; set; }

        public string Objetivo { get; set; }
        public string DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

       
    }
}
