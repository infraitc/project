using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using code_first.Interfaces;
using code_first.Models;

namespace code_first.Services
{
    public class AdminRepository : IAdminRepository
    {
        private readonly StudentContext _context;

        public AdminRepository(StudentContext context)
        {
            _context = context;
        }

        public bool Delete(long id)
        {
            var data = GetById(id);
            if (data == null)
            {
                return false;
            }

            _context.Admins.Remove(data);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }

        public IQueryable<Admin> GetByCondition()
        {
            throw new NotImplementedException();
        }

        public Admin GetById(long id)
        {
            return _context.Admins.SingleOrDefault(t => t.AdminId == id);
        }

        public Admin Insert(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();

            return admin;
        }

        public Admin Update(Admin admin, long id)
        {
            var data = GetById(id);
            if (data != null)
            {
                data.AdminCode = admin.AdminCode;
                data.AdminUsername = admin.AdminUsername;
                data.AdminEmail = admin.AdminEmail;

                _context.Admins.Update(data);
                _context.SaveChanges();
            }

            return data;
        }
    }
}