using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Dtos
{
   public class CandidaturaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

    }
}
