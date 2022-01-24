using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Core.Interfaces.Services;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Services
{
    public class ServiceVaga : ServiceBase<Vaga>, IServiceVaga
    {
        private readonly IRepositoryVaga repositoryVaga;

        public ServiceVaga(IRepositoryVaga repositoryVaga)
            : base(repositoryVaga)
        {
            this.repositoryVaga = repositoryVaga;
        }



        public IEnumerable<Vaga> GetVagasNaoAssociadas(int idCandidato)
        {
            return repositoryVaga.GetVagasNaoAssociadas(idCandidato);
        }


    }
}
