using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class Game5AttemptdataRepository : GenericRepository<TblGameAttemptdata>, IGame5AttemptdataRepository
    {
        public Game5AttemptdataRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
    
}
