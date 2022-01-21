using RestApiAts.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Interface
{
  public  interface IApplicationServiceCandidatura
    {
        IEnumerable<CandidaturaDto> GetAll();

        CandidaturaDto GetById(int id);


    }
}
