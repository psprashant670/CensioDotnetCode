
using DataAccess.EFCore.Data;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly db_censio_betaContext _context;
        public UnitOfWork(db_censio_betaContext context)
        {
            _context = context;
            //Developers = new DeveloperRepository(_context);
            //Projects = new ProjectRepository(_context);
        }
        //public IDeveloperRepository Developers { get; private set; }
        //public IProjectRepository Projects { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
