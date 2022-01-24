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

        IEnumerable<CandidaturaDto> GetListaVagasAtivas(int id);

        void Update(CandidaturaDto candidaturaDto);


        void Add(CandidaturaDto candidaturaDto);

    }
}
