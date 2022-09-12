using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class Game3FestivalResetRepository : GenericRepository<TblGame3FestivalReset>, IGame3FestivalResetRepository
    {
        public Game3FestivalResetRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
}
