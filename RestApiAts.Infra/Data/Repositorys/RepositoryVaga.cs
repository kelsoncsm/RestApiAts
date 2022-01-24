using Microsoft.EntityFrameworkCore;
using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public IEnumerable<Vaga> GetVagasNaoAssociadas(int idCandidato)

        {


            IQueryable<Vaga> query = sqlContext.Vagas.Where(a => !sqlContext.Candidaturas.Any(b => b.Vaga.Id == a.Id &&  b.Candidato.Id == idCandidato ) );


            return query.ToList();

        }

    }
}