using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class GameChallengelevelRepository : GenericRepository<TblGameChallengelevel>, IGameChallengelevelRepository
    {
        public GameChallengelevelRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
    
}
