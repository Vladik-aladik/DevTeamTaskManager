﻿namespace BuildingBlocks.Domain.Persistance;

public interface IRepositoryBase<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
{
}