using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    class Game4WordMasterRepository : GenericRepository<TblGame4WordMaster>, IGame4WordMasterRepository
    {
        public Game4WordMasterRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
}
