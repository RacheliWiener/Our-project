using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class השבחותDAL : IהשבחותDAL
    {
        private readonly WinTechContext _context;

        public השבחותDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addהשבחות(השבחות השבחות)
        {
            _context.השבחותs.Add(השבחות);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public השבחות GetהשבחותById(int id)
        {
            return _context.השבחותs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all השבחות)
        public List<השבחות> GetAllהשבחותs()
        {
            return _context.השבחותs.ToList();
        }

        // Update
        public void Updateהשבחות(השבחות השבחות)
        {
            var existingהשבחות = _context.השבחותs.FirstOrDefault(c => c.מזהה == השבחות.מזהה);
            if (existingהשבחות != null)
            {
                _context.Entry(existingהשבחות).CurrentValues.SetValues(השבחות);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteהשבחות(int id)
        {
            var השבחותToDelete = _context.השבחותs.FirstOrDefault(c => c.מזהה == id);
            if (השבחותToDelete != null)
            {
                _context.השבחותs.Remove(השבחותToDelete);
                _context.SaveChanges();
            }
        }
    }
}
