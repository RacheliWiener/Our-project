using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_עטיפהDAL
    {
        private readonly WinTechContext _context;

        public מחירון_עטיפהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_עטיפה(מחירון_עטיפה מחירון_עטיפה)
        {
            _context.מחירון_עטיפהs.Add(מחירון_עטיפה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_עטיפה Getמחירון_עטיפהById(int id)
        {
            return _context.מחירון_עטיפהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_עטיפה)
        public List<מחירון_עטיפה> GetAllמחירון_עטיפהs()
        {
            return _context.מחירון_עטיפהs.ToList();
        }

        // Update
        public void Updateמחירון_עטיפה(מחירון_עטיפה מחירון_עטיפה)
        {
            var existingמחירון_עטיפה = _context.מחירון_עטיפהs.FirstOrDefault(c => c.מזהה == מחירון_עטיפה.מזהה);
            if (existingמחירון_עטיפה != null)
            {
                _context.Entry(existingמחירון_עטיפה).CurrentValues.SetValues(מחירון_עטיפה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_עטיפה(int id)
        {
            var מחירון_עטיפהToDelete = _context.מחירון_עטיפהs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_עטיפהToDelete != null)
            {
                _context.מחירון_עטיפהs.Remove(מחירון_עטיפהToDelete);
                _context.SaveChanges();
            }
        }

    }
}
