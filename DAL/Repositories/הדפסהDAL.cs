using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class הדפסהDAL
    {
        private readonly WinTechContext _context;

        public הדפסהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addהדפסה(הדפסה הדפסה)
        {
            _context.הדפסהs.Add(הדפסה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public הדפסה GetהדפסהById(int id)
        {
            return _context.הדפסהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all הדפסה)
        public List<הדפסה> GetAllהדפסהs()
        {
            return _context.הדפסהs.ToList();
        }

        // Update
        public void Updateהדפסה(הדפסה הדפסה)
        {
            var existingהדפסה = _context.הדפסהs.FirstOrDefault(c => c.מזהה == הדפסה.מזהה);
            if (existingהדפסה != null)
            {
                _context.Entry(existingהדפסה).CurrentValues.SetValues(הדפסה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteהדפסה(int id)
        {
            var הדפסהToDelete = _context.הדפסהs.FirstOrDefault(c => c.מזהה == id);
            if (הדפסהToDelete != null)
            {
                _context.הדפסהs.Remove(הדפסהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
