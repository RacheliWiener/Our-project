using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class גלופותDAL
    {
        private readonly WinTechContext _context;

        public גלופותDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addגלופה(גלופות גלופה)
        {
            _context.גלופותs.Add(גלופה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public גלופות GetגלופהById(int id)
        {
            return _context.גלופותs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all גלופות)
        public List<גלופות> GetAllגלופותs()
        {
            return _context.גלופותs.ToList();
        }

        // Update
        public void Updateלקוח(גלופות גלופה)
        {
            var existingגלופה = _context.גלופותs.FirstOrDefault(c => c.מזהה == גלופה.מזהה);
            if (existingגלופה != null)
            {
                _context.Entry(existingגלופה).CurrentValues.SetValues(גלופה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteלקוח(int id)
        {
            var גלופהToDelete = _context.גלופותs.FirstOrDefault(c => c.מזהה == id);
            if (גלופהToDelete != null)
            {
                _context.גלופותs.Remove(גלופהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
