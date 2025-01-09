using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class אריזת_קרטוןDAL
    {
        private readonly WinTechContext _context;

        public אריזת_קרטוןDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addאריזת_קרטון(אריזת_קרטון אריזת_קרטון)
        {
            _context.אריזת_קרטוןs.Add(אריזת_קרטון);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public אריזת_קרטון Getאריזת_קרטוןById(int id)
        {
            return _context.אריזת_קרטוןs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<אריזת_קרטון> GetAllאריזת_קרטוןs()
        {
            return _context.אריזת_קרטוןs.ToList();
        }

        // Update
        public void Updateאריזת_קרטון(אריזת_קרטון אריזת_קרטון)
        {
            var existingאריזת_קרטון = _context.אריזת_קרטוןs.FirstOrDefault(c => c.מזהה == אריזת_קרטון.מזהה);
            if (existingאריזת_קרטון != null)
            {
                _context.Entry(existingאריזת_קרטון).CurrentValues.SetValues(אריזת_קרטון);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteאריזת_קרטון(int id)
        {
            var אריזת_קרטוןToDelete = _context.אריזת_קרטוןs.FirstOrDefault(c => c.מזהה == id);
            if (אריזת_קרטוןToDelete != null)
            {
                _context.אריזת_קרטוןs.Remove(אריזת_קרטוןToDelete);
                _context.SaveChanges();
            }
        }
    }
}
