using Microsoft.EntityFrameworkCore;
using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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

  
        //public IEnumerable<Candidatura> GetCandidaturaAll()
        //{
        //    IQueryable<Candidatura> query = sqlContext.Candidaturas;

        //    query = query.Include(p => p.Candidato);

        //    query = query.AsNoTracking()
        //        .OrderBy(p => p.Id)
        //        .Where(p => p.Candidato.Id == p.Id);
        //    //return sqlContext.Set<Candidatura>().ToList();

        //    return query.ToList();
        //}

        //public Candidatura GetCandidaturaById(int id)
        //{
        //    return sqlContext.Set<Candidatura>().Find(id);
        //}





    }
}