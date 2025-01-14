using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class פרויקטיםDAL
    {
        private readonly WinTechContext _context;

        public פרויקטיםDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addפרויקטים(פרויקטים פרויקטים)
        {
            _context.פרויקטיםs.Add(פרויקטים);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public פרויקטים GetפרויקטיםById(int id)
        {
            return _context.פרויקטיםs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<פרויקטים> GetAllפרויקטיםs()
        {
            return _context.פרויקטיםs.ToList();
        }

        // Update
        public void Updateפרויקטים(פרויקטים פרויקטים)
        {
            var existingפרויקטים = _context.פרויקטיםs.FirstOrDefault(c => c.מזהה == פרויקטים.מזהה);
            if (existingפרויקטים != null)
            {
                _context.Entry(existingפרויקטים).CurrentValues.SetValues(פרויקטים);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteפרויקטים(int id)
        {
            var פרויקטיםToDelete = _context.פרויקטיםs.FirstOrDefault(c => c.מזהה == id);
            if (פרויקטיםToDelete != null)
            {
                _context.פרויקטיםs.Remove(פרויקטיםToDelete);
                _context.SaveChanges();
            }
        }
    }
}
