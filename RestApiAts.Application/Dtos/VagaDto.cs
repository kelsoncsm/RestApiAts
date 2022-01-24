using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Dtos
{
   public class VagaDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Requisitos { get; set; }
        public bool IsAtivo { get; set; }

        public int IdVaga { get; set; }
        

    }
}
