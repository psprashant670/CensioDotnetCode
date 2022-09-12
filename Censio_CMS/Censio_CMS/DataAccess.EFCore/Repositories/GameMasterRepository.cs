using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class GameMasterRepository : GenericRepository<TblGameMaster>, IGameMasterRepository
    {
        public GameMasterRepository(db_censio_betaContext context) : base(context)
        {

        }

    }
    
}
