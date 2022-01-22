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
                .Include(h => h.Vaga);




            //var innerJoin = from c in sqlContext.Candidaturas
            //                join ca in sqlContext.Candidatos on c.IdCandidato equals ca.Id
            //                join va in sqlContext.Vagas on c.IdVaga equals va.Id
            //                select new 
            //                {
            //                    Descricao = va.Descricao,
            //                    Nome = String.Format("{0} {1}", ca.Nome, ca.SobreNome),
            //                    DataInicio = va.DataInicio,
            //                    DataFim = va.DataFim
            //                };


        //    return db.TimelineItems.Where(tl => tl.ProductID == SelectedPID)
        //.Select(tl => new TimelineItem
        //{
        //    Description = tl.Description,
        //    Title = tl.Title
        //})


            return query.ToList();
        }










    }
}