using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class צבעDAL
    {
        private readonly WinTechContext _context;

        public צבעDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addצבע(צבע צבע)
        {
            _context.צבעs.Add(צבע);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public צבע GetצבעById(int id)
        {
            return _context.צבעs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<צבע> GetAllצבעs()
        {
            return _context.צבעs.ToList();
        }

        // Update
        public void Updateצבע(צבע צבע)
        {
            var existingצבע = _context.צבעs.FirstOrDefault(c => c.מזהה == צבע.מזהה);
            if (existingצבע != null)
            {
                _context.Entry(existingצבע).CurrentValues.SetValues(צבע);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteצבע(int id)
        {
            var צבעToDelete = _context.צבעs.FirstOrDefault(c => c.מזהה == id);
            if (צבעToDelete != null)
            {
                _context.צבעs.Remove(צבעToDelete);
                _context.SaveChanges();
            }
        }
    }
}
