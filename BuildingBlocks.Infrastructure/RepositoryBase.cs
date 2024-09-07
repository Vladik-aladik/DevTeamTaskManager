﻿using BuildingBlocks.Domain;
using BuildingBlocks.Domain.Persistance;

namespace BuildingBlocks.Infrastructure;

public abstract class RepositoryBase<TAggregateRoot> : IRepositoryBase<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
{
}