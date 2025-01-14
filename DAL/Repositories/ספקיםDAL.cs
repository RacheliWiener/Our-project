using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ספקיםDAL
    {
        private readonly WinTechContext _context;

        public ספקיםDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addספקים(ספקים ספקים)
        {
            _context.ספקיםs.Add(ספקים);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public ספקים GetספקיםById(int id)
        {
            return _context.ספקיםs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<ספקים> GetAllספקיםs()
        {
            return _context.ספקיםs.ToList();
        }

        // Update
        public void Updateספקים(ספקים ספקים)
        {
            var existingספקים = _context.ספקיםs.FirstOrDefault(c => c.מזהה == ספקים.מזהה);
            if (existingספקים != null)
            {
                _context.Entry(existingספקים).CurrentValues.SetValues(ספקים);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteספקים(int id)
        {
            var ספקיםToDelete = _context.ספקיםs.FirstOrDefault(c => c.מזהה == id);
            if (ספקיםToDelete != null)
            {
                _context.ספקיםs.Remove(ספקיםToDelete);
                _context.SaveChanges();
            }
        }
    }
}
