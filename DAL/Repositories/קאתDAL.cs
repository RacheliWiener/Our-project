using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
   public class קאתDAL
    {
        private readonly WinTechContext _context;

        public קאתDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addקאת(קאת קאת)
        {
            _context.קאתs.Add(קאת);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public קאת GetקאתById(int id)
        {
            return _context.קאתs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all קאת)
        public List<קאת> GetAllקאתs()
        {
            return _context.קאתs.ToList();
        }

        // Update
        public void Updateקאת(קאת קאת)
        {
            var existingקאת = _context.קאתs.FirstOrDefault(c => c.מזהה == קאת.מזהה);
            if (existingקאת != null)
            {
                _context.Entry(existingקאת).CurrentValues.SetValues(קאת);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteקאת(int id)
        {
            var קאתToDelete = _context.קאתs.FirstOrDefault(c => c.מזהה == id);
            if (קאתToDelete != null)
            {
                _context.קאתs.Remove(קאתToDelete);
                _context.SaveChanges();
            }
        }
    }
}
