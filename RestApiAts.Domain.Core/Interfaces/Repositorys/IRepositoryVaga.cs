using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryVaga : IRepositoryBase<Vaga>
    {



        IEnumerable<Vaga> GetVagasNaoAssociadas(int idCandidato);


    }
}
