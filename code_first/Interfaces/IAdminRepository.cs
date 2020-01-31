using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using code_first.Models;

namespace code_first.Interfaces
{
    public interface IAdminRepository
    {
        IEnumerable<Admin> GetAll();
        IQueryable<Admin> GetByCondition();
        Admin GetById(long id);
        Admin Insert(Admin admin);
        Admin Update(Admin admin, long id);
        bool Delete(long id);
    }
}