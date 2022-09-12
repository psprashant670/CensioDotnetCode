using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
   public class Game3InstructionsRepository : GenericRepository<TblGame3Instructions>, IGame3InstructionsRepository
    {
        public Game3InstructionsRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
}
