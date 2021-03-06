﻿using System;
using System.Web.Http;
using Project.API.Base.Controllers;
using Project.API.Base.MapperAdapters;
using Project.API.Publicacoes.Models.Conteudo;
using Project.Domain.Publicacoes.Interfaces;
using Project.Models.Publicacoes.Entities;

namespace Project.API.Publicacoes.Controllers
{
    public class ConteudosController : GenericBaseApiControllerAsync
        <Guid, IConteudoDomain, Conteudo, ConteudoModel, ConteudoGetModel, ConteudoListItemModel, ConteudoPostModel, ConteudoPutModel>
    {
        #region - CONSTRUCTORS -

        public ConteudosController(IConteudoDomain domain, IMapperAdapter mapperAdapter)
            : base(domain, mapperAdapter)
        {
        }

        #endregion

        #region - MAIN METHODS -

        [Authorize]
        public override IHttpActionResult Get()
        {
            return base.Get();
        }

        #endregion
    }
}