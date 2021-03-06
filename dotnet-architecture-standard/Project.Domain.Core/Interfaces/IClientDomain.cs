﻿using Project.Domain.Core.Interfaces.Base;
using Project.Models.Core.Entities;

namespace Project.Domain.Core.Interfaces
{
    public interface IClientDomain : IDomainBase<Client>, IDomainBaseAsync<Client>
    {
    }
}