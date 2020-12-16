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
        private IGenericRepository<Docent> repoDocent;


        public UnitOfWork(WhizMAContext context)
        {
            _context = context;
        }

        public IGenericRepository<Docent> RepoDocent
        {
            get
            {
                if (this.repoDocent == null)
                {
                    this.repoDocent = new GenericRepository<Docent>(_context);
                }
                return repoDocent;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
