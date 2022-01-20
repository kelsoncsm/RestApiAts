using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Entity
{
   public class Vaga : Base
    {
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Requisitos { get; set; }


    }
}
