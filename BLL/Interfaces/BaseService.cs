using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public abstract class BaseService
    {
        protected readonly UnitOfWork _unitOfWork;
        protected BaseService(UnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        protected virtual async Task<bool> SaveAsync() => await _unitOfWork.Save() > 0;
    }
}
