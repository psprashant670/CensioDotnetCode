using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    class Game4LevelInstructionsRepository : GenericRepository<TblGame4LevelInstructions>, IGame4LevelInstructionsRepository
    {
        public Game4LevelInstructionsRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
    
}
