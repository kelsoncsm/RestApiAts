using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Core.Interfaces.Services
{
    public interface IServiceCandidatura : IServiceBase<Candidatura>
    {

        IEnumerable<Candidatura> GetAll2();


        IEnumerable<Candidatura> GetListaVagasAtivas(int idCandidato);


    }

}
