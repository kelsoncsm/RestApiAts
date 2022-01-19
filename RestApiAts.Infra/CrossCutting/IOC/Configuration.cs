using Autofac;
using AutoMapper;
using RestApiAts.Application;
using RestApiAts.Application.Interface;
using RestApiAts.Application.Mappers;
using RestApiAts.Domain.Core.Interfaces.Repositorys;
using RestApiAts.Domain.Core.Interfaces.Services;
using RestApiAts.Domain.Services;
using RestApiAts.Infra.Data.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Infra.CrossCutting.IOC
{
   public class Configuration
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCandidato>().As<IApplicationServiceCandidato>();
            builder.RegisterType<ApplicationServiceVaga>().As<IApplicationServiceVaga>();

            builder.RegisterType<ServiceCandidato>().As<IServiceCandidato>();
            builder.RegisterType<ServiceVaga>().As<IServiceVaga>();

            builder.RegisterType<RepositoryCandidato>().As<IRepositoryCandidato>();
            builder.RegisterType<RepositoryVaga>().As<IRepositoryVaga>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingCandidato());
                cfg.AddProfile(new ModelToDtoMappingCandidato());
                cfg.AddProfile(new DtoToModelMappingVaga());
                cfg.AddProfile(new ModelToDtoMappingVaga());


            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}