using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class עטיפהDAL
    {
        private readonly WinTechContext _context;

        public עטיפהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addעטיפה(עטיפה עטיפה)
        {
            _context.עטיפהs.Add(עטיפה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public עטיפה GetעטיפהById(int id)
        {
            return _context.עטיפהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<עטיפה> GetAllעטיפהs()
        {
            return _context.עטיפהs.ToList();
        }

        // Update
        public void Updateעטיפה(עטיפה עטיפה)
        {
            var existingעטיפה = _context.עטיפהs.FirstOrDefault(c => c.מזהה == עטיפה.מזהה);
            if (existingעטיפה != null)
            {
                _context.Entry(existingעטיפה).CurrentValues.SetValues(עטיפה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteעטיפה(int id)
        {
            var עטיפהToDelete = _context.עטיפהs.FirstOrDefault(c => c.מזהה == id);
            if (עטיפהToDelete != null)
            {
                _context.עטיפהs.Remove(עטיפהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
