using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Infra.Data.Repositorys
{
    class RepositoryVaga : RepositoryBase<Vaga>, IRepositoryVaga
    {
        private readonly SqlContext sqlContext;

        public RepositoryVaga(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}