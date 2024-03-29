﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core.Repositories
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        IQueryable<IGrouping<Country, Actor>> GetActorsGroupedByCountry();
    }
}
