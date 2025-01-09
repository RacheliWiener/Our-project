using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class לוחותDAL : IלוחותDAL
    {
        private readonly WinTechContext _context;

        public לוחותDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addלוח(לוחות לוח)
        {
            _context.לוחותs.Add(לוח);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public לוחות GetלוחById(int id)
        {
            return _context.לוחותs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all לוחות)
        public List<לוחות> GetAllלוחותs()
        {
            return _context.לוחותs.ToList();
        }

        // Update
        public void Updateלוח(לוחות לוח)
        {
            var existingלוח = _context.לוחותs.FirstOrDefault(c => c.מזהה == לוח.מזהה);
            if (existingלוח != null)
            {
                _context.Entry(existingלוח).CurrentValues.SetValues(לוח);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteלוח(int id)
        {
            var לוחToDelete = _context.לוחותs.FirstOrDefault(c => c.מזהה == id);
            if (לוחToDelete != null)
            {
                _context.לוחותs.Remove(לוחToDelete);
                _context.SaveChanges();
            }
        }
    }
}
