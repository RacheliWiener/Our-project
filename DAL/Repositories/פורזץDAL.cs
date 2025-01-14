using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
     public class פורזץDAL
    {
        private readonly WinTechContext _context;

        public פורזץDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addפורזץ(פורזץ פורזץ)
        {
            _context.פורזץs.Add(פורזץ);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public פורזץ GetפורזץById(int id)
        {
            return _context.פורזץs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<פורזץ> GetAllפורזץs()
        {
            return _context.פורזץs.ToList();
        }

        // Update
        public void Updateפורזץ(פורזץ פורזץ)
        {
            var existingפורזץ = _context.פורזץs.FirstOrDefault(c => c.מזהה == פורזץ.מזהה);
            if (existingפורזץ != null)
            {
                _context.Entry(existingפורזץ).CurrentValues.SetValues(פורזץ);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteפורזץ(int id)
        {
            var פורזץToDelete = _context.פורזץs.FirstOrDefault(c => c.מזהה == id);
            if (פורזץToDelete != null)
            {
                _context.פורזץs.Remove(פורזץToDelete);
                _context.SaveChanges();
            }
        }
    }
}
