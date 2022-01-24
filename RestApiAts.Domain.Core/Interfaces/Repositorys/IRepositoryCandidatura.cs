using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Core.Interfaces.Repositorys
{
   public interface IRepositoryCandidatura : IRepositoryBase<Candidatura>
    {



        IEnumerable<Candidatura> GetAll2();

        IEnumerable<Candidatura> GetListaVagasAtivas(int idCandidato);


    }
}
