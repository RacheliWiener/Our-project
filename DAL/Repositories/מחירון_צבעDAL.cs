using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_צבעDAL
    {
        private readonly WinTechContext _context;

        public מחירון_צבעDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_צבע(מחירון_צבע מחירון_צבע)
        {
            _context.מחירון_צבעs.Add(מחירון_צבע);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_צבע Getמחירון_צבעById(int id)
        {
            return _context.מחירון_צבעs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<מחירון_צבע> GetAllמחירון_צבעs()
        {
            return _context.מחירון_צבעs.ToList();
        }

        // Update
        public void Updateמחירון_צבע(מחירון_צבע מחירון_צבע)
        {
            var existingמחירון_צבע = _context.מחירון_צבעs.FirstOrDefault(c => c.מזהה == מחירון_צבע.מזהה);
            if (existingמחירון_צבע != null)
            {
                _context.Entry(existingמחירון_צבע).CurrentValues.SetValues(מחירון_צבע);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_צבע(int id)
        {
            var מחירון_צבעToDelete = _context.מחירון_צבעs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_צבעToDelete != null)
            {
                _context.מחירון_צבעs.Remove(מחירון_צבעToDelete);
                _context.SaveChanges();
            }
        }
    }
}
