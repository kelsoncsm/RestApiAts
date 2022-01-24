using Microsoft.EntityFrameworkCore;
using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiAts.Infra.Data.Repositorys
{
    class RepositoryCandidatura : RepositoryBase<Candidatura>, IRepositoryCandidatura
    {
        private readonly SqlContext sqlContext;

        public RepositoryCandidatura(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }



        public IEnumerable<Candidatura> GetAll2()

        {


            IQueryable<Candidatura> query = sqlContext.Candidaturas
                .Include(h => h.Candidato)
                .Include(h => h.Vaga).Where(x=>x.IsAtivo == true);



            return query.ToList();
        }


        public IEnumerable<Candidatura> GetListaVagasAtivas(int idCandidato)

        {
        
            IQueryable<Candidatura> query = sqlContext.Candidaturas
                .Include(h => h.Candidato)
                .Include(h => h.Vaga).Where(x => x.IsAtivo == true && x.Candidato.Id == idCandidato) ;


            return query.ToList() ;
            
        }




    }
}