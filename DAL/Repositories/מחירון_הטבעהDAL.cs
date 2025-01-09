using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_הטבעהDAL
    {
        private readonly WinTechContext _context;

        public מחירון_הטבעהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_הטבעה(מחירון_הטבעה מחירון_הטבעה)
        {
            _context.מחירון_הטבעהs.Add(מחירון_הטבעה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_הטבעה Getמחירון_הטבעהById(int id)
        {
            return _context.מחירון_הטבעהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_הטבעה)
        public List<מחירון_הטבעה> GetAllמחירון_הטבעהs()
        {
            return _context.מחירון_הטבעהs.ToList();
        }

        // Update
        public void Updateמחירון_הטבעה(מחירון_הטבעה מחירון_הטבעה)
        {
            var existingמחירון_הטבעה = _context.מחירון_הטבעהs.FirstOrDefault(c => c.מזהה == מחירון_הטבעה.מזהה);
            if (existingמחירון_הטבעה != null)
            {
                _context.Entry(existingמחירון_הטבעה).CurrentValues.SetValues(מחירון_הטבעה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_הטבעה(int id)
        {
            var מחירון_הטבעהToDelete = _context.מחירון_הטבעהs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_הטבעהToDelete != null)
            {
                _context.מחירון_הטבעהs.Remove(מחירון_הטבעהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
