using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_השבחותDAL
    {
        private readonly WinTechContext _context;

        public מחירון_השבחותDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_השבחות(מחירון_השבחות מחירון_השבחות)
        {
            _context.מחירון_השבחותs.Add(מחירון_השבחות);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_השבחות Getמחירון_השבחותById(int id)
        {
            return _context.מחירון_השבחותs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_השבחות)
        public List<מחירון_השבחות> GetAllמחירון_השבחותs()
        {
            return _context.מחירון_השבחותs.ToList();
        }

        // Update
        public void Updateמחירון_השבחות(מחירון_השבחות מחירון_השבחות)
        {
            var existingמחירון_השבחות = _context.מחירון_השבחותs.FirstOrDefault(c => c.מזהה == מחירון_השבחות.מזהה);
            if (existingמחירון_השבחות != null)
            {
                _context.Entry(existingמחירון_השבחות).CurrentValues.SetValues(מחירון_השבחות);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_השבחות(int id)
        {
            var מחירון_השבחותToDelete = _context.מחירון_השבחותs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_השבחותToDelete != null)
            {
                _context.מחירון_השבחותs.Remove(מחירון_השבחותToDelete);
                _context.SaveChanges();
            }
        }
    }
}
