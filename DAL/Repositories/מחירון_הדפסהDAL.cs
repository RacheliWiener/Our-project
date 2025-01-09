using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_הדפסהDAL : Iמחירון_הדפסהDAL
    {
        private readonly WinTechContext _context;

        public מחירון_הדפסהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_הדפסה(מחירון_הדפסה מחירון_הדפסה)
        {
            _context.מחירון_הדפסהs.Add(מחירון_הדפסה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_הדפסה Getמחירון_הדפסהById(int id)
        {
            return _context.מחירון_הדפסהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_הדפסה)
        public List<מחירון_הדפסה> GetAllמחירון_הדפסהs()
        {
            return _context.מחירון_הדפסהs.ToList();
        }

        // Update
        public void Updateמחירון_הדפסה(מחירון_הדפסה מחירון_הדפסה)
        {
            var existingמחירון_הדפסה = _context.מחירון_הדפסהs.FirstOrDefault(c => c.מזהה == מחירון_הדפסה.מזהה);
            if (existingמחירון_הדפסה != null)
            {
                _context.Entry(existingמחירון_הדפסה).CurrentValues.SetValues(מחירון_הדפסה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_הדפסה(int id)
        {
            var מחירון_הדפסהToDelete = _context.מחירון_הדפסהs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_הדפסהToDelete != null)
            {
                _context.מחירון_הדפסהs.Remove(מחירון_הדפסהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
