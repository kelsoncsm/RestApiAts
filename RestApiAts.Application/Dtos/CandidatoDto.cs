using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Dtos
{
   public class CandidatoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
        
    }
}
