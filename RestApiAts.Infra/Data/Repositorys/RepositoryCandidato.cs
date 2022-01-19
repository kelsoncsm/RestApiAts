using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Infra.Data.Repositorys
{
    class RepositoryCandidato : RepositoryBase<Candidato>, IRepositoryCandidato
    {
        private readonly SqlContext sqlContext;

        public RepositoryCandidato(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}