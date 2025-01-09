using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class לייןDAL : IלייןDAL
    {
        private readonly WinTechContext _context;

        public לייןDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addליין(ליין ליין)
        {
            _context.לייןs.Add(ליין);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public ליין GetלייןById(int id)
        {
            return _context.לייןs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all ליין)
        public List<ליין> GetAllלייןs()
        {
            return _context.לייןs.ToList();
        }

        // Update
        public void Updateליין(ליין ליין)
        {
            var existingליין = _context.לייןs.FirstOrDefault(c => c.מזהה == ליין.מזהה);
            if (existingליין != null)
            {
                _context.Entry(existingליין).CurrentValues.SetValues(ליין);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteליין(int id)
        {
            var לייןToDelete = _context.לייןs.FirstOrDefault(c => c.מזהה == id);
            if (לייןToDelete != null)
            {
                _context.לייןs.Remove(לייןToDelete);
                _context.SaveChanges();
            }
        }
    }
}
