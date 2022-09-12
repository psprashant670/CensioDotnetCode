using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class Game4LevelImagesRepository : GenericRepository<TblGame4LevelImages>, IGame4LevelImagesRepository
    {
        public Game4LevelImagesRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
}
