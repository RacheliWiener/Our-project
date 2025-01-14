using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_קאתDAL
    {
        private readonly WinTechContext _context;

        public מחירון_קאתDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_קאת(מחירון_קאת מחירון_קאת)
        {
            _context.מחירון_קאתs.Add(מחירון_קאת);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_קאת Getמחירון_קאתById(int id)
        {
            return _context.מחירון_קאתs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_קאת)
        public List<מחירון_קאת> GetAllמחירון_קאתs()
        {
            return _context.מחירון_קאתs.ToList();
        }

        // Update
        public void Updateמחירון_קאת(מחירון_קאת מחירון_קאת)
        {
            var existingמחירון_קאת = _context.מחירון_קאתs.FirstOrDefault(c => c.מזהה == מחירון_קאת.מזהה);
            if (existingמחירון_קאת != null)
            {
                _context.Entry(existingמחירון_קאת).CurrentValues.SetValues(מחירון_קאת);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_קאת(int id)
        {
            var מחירון_קאתToDelete = _context.מחירון_קאתs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_קאתToDelete != null)
            {
                _context.מחירון_קאתs.Remove(מחירון_קאתToDelete);
                _context.SaveChanges();
            }
        }
    }
}
