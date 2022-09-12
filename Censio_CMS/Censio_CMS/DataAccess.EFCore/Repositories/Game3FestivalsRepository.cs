using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class Game3FestivalsRepository : GenericRepository<TblGame3Festivals>, IGame3FestivalsRepository
    {
        public Game3FestivalsRepository(db_censio_betaContext context) : base(context)
        {
        }

    }

}
