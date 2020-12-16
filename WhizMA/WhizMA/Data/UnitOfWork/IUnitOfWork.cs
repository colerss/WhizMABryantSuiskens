using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Data.Repository;
using WhizMA.Models;

namespace WhizMA.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Docent> RepoDocent { get; }
        Task Save();
    }
}
