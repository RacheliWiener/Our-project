using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_סימניהDAL
    {
        private readonly WinTechContext _context;

        public מחירון_סימניהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_סימניה(מחירון_סימניה מחירון_סימניה)
        {
            _context.מחירון_סימניהs.Add(מחירון_סימניה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_סימניה Getמחירון_סימניהById(int id)
        {
            return _context.מחירון_סימניהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_סימניה)
        public List<מחירון_סימניה> GetAllמחירון_סימניהs()
        {
            return _context.מחירון_סימניהs.ToList();
        }

        // Update
        public void Updateמחירון_סימניה(מחירון_סימניה מחירון_סימניה)
        {
            var existingמחירון_סימניה = _context.מחירון_סימניהs.FirstOrDefault(c => c.מזהה == מחירון_סימניה.מזהה);
            if (existingמחירון_סימניה != null)
            {
                _context.Entry(existingמחירון_סימניה).CurrentValues.SetValues(מחירון_סימניה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_סימניה(int id)
        {
            var מחירון_סימניהToDelete = _context.מחירון_סימניהs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_סימניהToDelete != null)
            {
                _context.מחירון_סימניהs.Remove(מחירון_סימניהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
