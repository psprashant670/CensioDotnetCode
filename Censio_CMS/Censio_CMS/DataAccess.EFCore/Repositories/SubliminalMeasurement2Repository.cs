using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class SubliminalMeasurement2Repository : GenericRepository<TblSubliminalMeasurement2>, ISubliminalMeasurement2Repository
    {
        public SubliminalMeasurement2Repository(db_censio_betaContext context) : base(context)
        {
        }

    }
   
}
