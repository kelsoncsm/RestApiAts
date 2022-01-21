using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Entity
{
    public class Candidatura : Base
    {
        public Candidato Candidato { get; set; }
        public Vaga Vaga { get; set; }


    }
}