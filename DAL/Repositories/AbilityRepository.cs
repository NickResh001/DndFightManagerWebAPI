using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AbilityRepository : IRepository<Ability>
    {
        private DndFightManagerDBContext _db;
        public AbilityRepository(DndFightManagerDBContext dbContext) => _db = dbContext;

        public async Task<List<Ability>> GetAll() => await _db.Abilities.ToListAsync();
        public async Task<Ability> GetById(string id) => await _db.Abilities.FindAsync(id);
        public async Task<bool> Exists(string id) => await _db.Abilities.AnyAsync(e => e.Id == id);
        public async Task Create(Ability entity) => await _db.Abilities.AddAsync(entity);
        public async Task Update(Ability entity) => _db.Entry(entity).State = EntityState.Modified;
        public async Task<bool> Delete(string id)
        {
            var ability = await _db.Abilities.FindAsync(id);
            if (ability == null)
                return false;

            _db.Abilities.Remove(ability);
            return true;
        }

    }
}
