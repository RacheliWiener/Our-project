using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_פורזץDAL
    {
        private readonly WinTechContext _context;

        public מחירון_פורזץDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_פורזץ(מחירון_פורזץ מחירון_פורזץ)
        {
            _context.מחירון_פורזץs.Add(מחירון_פורזץ);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_פורזץ Getמחירון_פורזץById(int id)
        {
            return _context.מחירון_פורזץs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_פורזץ)
        public List<מחירון_פורזץ> GetAllמחירון_פורזץs()
        {
            return _context.מחירון_פורזץs.ToList();
        }

        // Update
        public void Updateמחירון_פורזץ(מחירון_פורזץ מחירון_פורזץ)
        {
            var existingמחירון_פורזץ = _context.מחירון_פורזץs.FirstOrDefault(c => c.מזהה == מחירון_פורזץ.מזהה);
            if (existingמחירון_פורזץ != null)
            {
                _context.Entry(existingמחירון_פורזץ).CurrentValues.SetValues(מחירון_פורזץ);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_פורזץ(int id)
        {
            var מחירון_פורזץToDelete = _context.מחירון_פורזץs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_פורזץToDelete != null)
            {
                _context.מחירון_פורזץs.Remove(מחירון_פורזץToDelete);
                _context.SaveChanges();
            }
        }
    }
}
