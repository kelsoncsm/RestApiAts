using RestApiAts.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Interface
{
  public  interface IApplicationServiceCandidato
    {

        void Add(CandidatoDto candidatoDto);

        void Update(CandidatoDto candidatoDto);

        void Remove(CandidatoDto candidatoDto);

        IEnumerable<CandidatoDto> GetAll();

        CandidatoDto GetById(int id);



    }
}
