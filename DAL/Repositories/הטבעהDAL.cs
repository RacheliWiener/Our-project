using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class הטבעהDAL : IהטבעהDAL
    {
        private readonly WinTechContext _context;

        public הטבעהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addהטבעה(הטבעה הטבעה)
        {
            _context.הטבעהs.Add(הטבעה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public הטבעה GetהטבעהById(int id)
        {
            return _context.הטבעהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all הטבעה)
        public List<הטבעה> GetAllהטבעהs()
        {
            return _context.הטבעהs.ToList();
        }

        // Update
        public void Updateהטבעה(הטבעה הטבעה)
        {
            var existingהטבעה = _context.הטבעהs.FirstOrDefault(c => c.מזהה == הטבעה.מזהה);
            if (existingהטבעה != null)
            {
                _context.Entry(existingהטבעה).CurrentValues.SetValues(הטבעה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteהטבעה(int id)
        {
            var הטבעהToDelete = _context.הטבעהs.FirstOrDefault(c => c.מזהה == id);
            if (הטבעהToDelete != null)
            {
                _context.הטבעהs.Remove(הטבעהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
