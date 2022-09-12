using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class Game4LevelMasterRepository : GenericRepository<TblGame4LevelMaster>, IGame4LevelMasterRepository
    {
        public Game4LevelMasterRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
}
