using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class הפקהDAL
    {
        private readonly WinTechContext _context;

        public הפקהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addהפקה(הפקה הפקה)
        {
            _context.הפקהs.Add(הפקה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public הפקה GetהפקהById(int id)
        {
            return _context.הפקהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all הפקות)
        public List<הפקה> GetAllהפקותs()
        {
            return _context.הפקהs.ToList();
        }

        // Update
        public void Updateהפקה(הפקה הפקה)
        {
            var existingהפקה = _context.הפקהs.FirstOrDefault(c => c.מזהה == הפקה.מזהה);
            if (existingהפקה != null)
            {
                _context.Entry(existingהפקה).CurrentValues.SetValues(הפקה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteהפקה(int id)
        {
            var הפקהToDelete = _context.הפקהs.FirstOrDefault(c => c.מזהה == id);
            if (הפקהToDelete != null)
            {
                _context.הפקהs.Remove(הפקהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
