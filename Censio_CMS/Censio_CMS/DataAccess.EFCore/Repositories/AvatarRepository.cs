using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class AvatarRepository : GenericRepository<TblAvatar>, IAvatarRepository
    {
        public AvatarRepository(db_censio_betaContext context) : base(context)
        {
        }

    }
    
}
