using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Data.Repository;
using WhizMA.Models;

namespace WhizMA.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WhizMAContext _context;
        private IGenericRepository<Cursus> repoCursus;


        public UnitOfWork(WhizMAContext context)
        {
            _context = context;
        }

        public IGenericRepository<Cursus> RepoCursus
        {
            get
            {
                if (this.repoCursus == null)
                {
                    this.repoCursus = new GenericRepository<Cursus>(_context);
                }
                return repoCursus;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
