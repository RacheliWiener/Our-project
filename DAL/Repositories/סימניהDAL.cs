using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class סימניהDAL
    {
        private readonly WinTechContext _context;

        public סימניהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addסימניה(סימניה סימניה)
        {
            _context.סימניהs.Add(סימניה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public סימניה GetסימניהById(int id)
        {
            return _context.סימניהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<סימניה> GetAllסימניהs()
        {
            return _context.סימניהs.ToList();
        }

        // Update
        public void Updateסימניה(סימניה סימניה)
        {
            var existingסימניה = _context.סימניהs.FirstOrDefault(c => c.מזהה == סימניה.מזהה);
            if (existingסימניה != null)
            {
                _context.Entry(existingסימניה).CurrentValues.SetValues(סימניה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteסימניה(int id)
        {
            var סימניהToDelete = _context.סימניהs.FirstOrDefault(c => c.מזהה == id);
            if (סימניהToDelete != null)
            {
                _context.סימניהs.Remove(סימניהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
