using BLL.Abstract;
using BLL.DTOs;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AbilityService : BaseService
    {
        public AbilityService(UnitOfWork unitOfWork) : base(unitOfWork) { }

        #region CRUD

        public async Task<bool> Create(AbilityDTO itemDTO)
        {
            var item = new Ability
            {
                Id = itemDTO.Id,
                Title = itemDTO.Title
            };

            await _unitOfWork.Ability.Create(item);
            return await SaveAsync();
        }
        public async Task<bool> Update(AbilityDTO itemDTO)
        {
            if (!await _unitOfWork.Ability.Exists(itemDTO.Id))
                return false;

            var item = await _unitOfWork.Ability.GetById(itemDTO.Id);

            item.Title = itemDTO.Title;
            await _unitOfWork.Ability.Update(item);
            return await SaveAsync();
        }
        public async Task<bool> Delete(string id)
        {
            if (!await _unitOfWork.Ability.Exists(id))
                return false;

            // Каскадное удаление связанных сущностей
            // ...

            await _unitOfWork.Ability.Delete(id);
            return await SaveAsync();
        }
        public async Task<bool> Exists(string id) => await _unitOfWork.Ability.Exists(id);
        public async Task<List<AbilityDTO>> GetAll()
        {
            var items = await _unitOfWork.Ability.GetAll();
            var result = items
                .Select(x => new AbilityDTO(x))
                .ToList();
            return result;
        }
        public async Task<AbilityDTO> GetById(string id)
        {
            var item = await _unitOfWork.Ability.GetById(id);
            return item == null ? null : new AbilityDTO(item);
        }
        
        #endregion
    }
}
