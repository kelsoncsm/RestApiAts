using RestApiAts.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Interface
{
    public interface IApplicationServiceVaga
    {
        void Add(VagaDto vagaDto);

        void Update(VagaDto vagaDto);

        void Remove(VagaDto vagaDto);

        IEnumerable<VagaDto> GetAll();

        VagaDto GetById(int id);


        IEnumerable<VagaDto> GetVagasNaoAssociadas(int id);

        
    }
}
