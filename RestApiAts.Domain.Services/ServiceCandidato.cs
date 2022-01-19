using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Core.Interfaces.Services;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Services
{
    public class ServiceCandidato : ServiceBase<Candidato>, IServiceCandidato
    {
        private readonly IRepositoryCandidato repositoryCandidato;

        public ServiceCandidato(IRepositoryCandidato repositoryCandidato)
            : base(repositoryCandidato)
        {
            this.repositoryCandidato = repositoryCandidato;
        }
    }
}
