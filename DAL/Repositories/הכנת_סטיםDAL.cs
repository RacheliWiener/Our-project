using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class הכנת_סטיםDAL : Iהכנת_סטיםDAL
    {
        private readonly WinTechContext _context;

        public הכנת_סטיםDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addהכנת_סטים(הכנת_סטים הכנת_סטים)
        {
            _context.הכנת_סטיםs.Add(הכנת_סטים);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public הכנת_סטים Getהכנת_סטיםById(int id)
        {
            return _context.הכנת_סטיםs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all הכנת_סטים)
        public List<הכנת_סטים> GetAllהכנת_סטיםs()
        {
            return _context.הכנת_סטיםs.ToList();
        }

        // Update
        public void Updateהכנת_סטים(הכנת_סטים הכנת_סטים)
        {
            var existingהכנת_סטים = _context.לקוחותs.FirstOrDefault(c => c.מזהה == הכנת_סטים.מזהה);
            if (existingהכנת_סטים != null)
            {
                _context.Entry(existingהכנת_סטים).CurrentValues.SetValues(הכנת_סטים);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteהכנת_סטים(int id)
        {
            var הכנת_סטיםToDelete = _context.הכנת_סטיםs.FirstOrDefault(c => c.מזהה == id);
            if (הכנת_סטיםToDelete != null)
            {
                _context.הכנת_סטיםs.Remove(הכנת_סטיםToDelete);
                _context.SaveChanges();
            }
        }
    }
}
