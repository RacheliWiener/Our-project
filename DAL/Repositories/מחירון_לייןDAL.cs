using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_לייןDAL
    {
        private readonly WinTechContext _context;

        public מחירון_לייןDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_ליין(מחירון_ליין מחירון_ליין)
        {
            _context.מחירון_לייןs.Add(מחירון_ליין);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_ליין Getמחירון_לייןById(int id)
        {
            return _context.מחירון_לייןs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_ליין)
        public List<מחירון_ליין> GetAllמחירון_לייןs()
        {
            return _context.מחירון_לייןs.ToList();
        }

        // Update
        public void Updateמחירון_ליין(מחירון_ליין מחירון_ליין)
        {
            var existingמחירון_ליין = _context.מחירון_לייןs.FirstOrDefault(c => c.מזהה == מחירון_ליין.מזהה);
            if (existingמחירון_ליין != null)
            {
                _context.Entry(existingמחירון_ליין).CurrentValues.SetValues(מחירון_ליין);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_ליין(int id)
        {
            var מחירון_לייןToDelete = _context.מחירון_לייןs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_לייןToDelete != null)
            {
                _context.מחירון_לייןs.Remove(מחירון_לייןToDelete);
                _context.SaveChanges();
            }
        }
    }
}
