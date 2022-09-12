﻿using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class Game3LevelsRepository : GenericRepository<TblGame3Levels>, IGame3LevelsRepository
    {
        public Game3LevelsRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
}
