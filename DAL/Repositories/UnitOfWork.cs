using DAL.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfWork
    {
        private readonly DndFightManagerDBContext _db;

        private AbilityRepository _abilityRepository;

        public UnitOfWork(IConfiguration configuration) 
        {
            _db = new DndFightManagerDBContext(configuration);
        }

        public AbilityRepository Ability 
        { 
            get 
            { 
                _abilityRepository ??= new AbilityRepository(_db);
                return _abilityRepository;
            } 
        }

        public async Task<int> Save()
        {
            try
            {
                return await _db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
