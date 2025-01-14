using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class שונותDAL
    {
        private readonly WinTechContext _context;

        public שונותDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addשונות(שונות שונות)
        {
            _context.שונותs.Add(שונות);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public שונות GetשונותById(int id)
        {
            return _context.שונותs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<שונות> GetAllשונותs()
        {
            return _context.שונותs.ToList();
        }

        // Update
        public void Updateשונות(שונות שונות)
        {
            var existingשונות = _context.שונותs.FirstOrDefault(c => c.מזהה == שונות.מזהה);
            if (existingשונות != null)
            {
                _context.Entry(existingשונות).CurrentValues.SetValues(שונות);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteשונות(int id)
        {
            var שונותToDelete = _context.שונותs.FirstOrDefault(c => c.מזהה == id);
            if (שונותToDelete != null)
            {
                _context.שונותs.Remove(שונותToDelete);
                _context.SaveChanges();
            }
        }
    }
}
