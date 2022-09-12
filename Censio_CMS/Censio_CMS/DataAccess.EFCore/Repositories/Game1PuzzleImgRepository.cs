using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class Game1PuzzleImgRepository : GenericRepository<TblPuzzleGame>, IGame1PuzzleImgRepository
    {
        public Game1PuzzleImgRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
    
}
