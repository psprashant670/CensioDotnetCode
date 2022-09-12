using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class SubliminalMeasurement1Repository : GenericRepository<TblSubliminalMeasurement1>, ISubliminalMeasurement1Repository
    {
        public SubliminalMeasurement1Repository(db_censio_betaContext context) : base(context)
        {
        }

    }
    
}
