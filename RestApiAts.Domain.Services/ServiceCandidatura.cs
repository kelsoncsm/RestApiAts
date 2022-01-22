using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Core.Interfaces.Services;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Domain.Services
{
    public class ServiceCandidatura : ServiceBase<Candidatura>, IServiceCandidatura
    {
        private readonly IRepositoryCandidatura repositoryCandidatura;

        public ServiceCandidatura(IRepositoryCandidatura repositoryCandidatura)
            : base(repositoryCandidatura)
        {
            this.repositoryCandidatura = repositoryCandidatura;
        }


        public IEnumerable<Candidatura> GetAll2()
        {
            return repositoryCandidatura.GetAll2();
        }



    }
}
