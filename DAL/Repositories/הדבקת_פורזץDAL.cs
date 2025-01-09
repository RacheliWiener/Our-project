using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class הדבקת_פורזץDAL : Iהדבקת_פורזץDAL
    {
        private readonly WinTechContext _context;

        public הדבקת_פורזץDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addהדבקת_פורזץ(הדבקת_פורזץ הדבקת_פורזץ)
        {
            _context.הדבקת_פורזץs.Add(הדבקת_פורזץ);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public הדבקת_פורזץ Getהדבקת_פורזץById(int id)
        {
            return _context.הדבקת_פורזץs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all הדבקת_פורזץ)
        public List<הדבקת_פורזץ> GetAllהדבקת_פורזץs()
        {
            return _context.הדבקת_פורזץs.ToList();
        }

        // Update
        public void Updateהדבקת_פורזץ(הדבקת_פורזץ הדבקת_פורזץ)
        {
            var existingהדבקת_פורזץ = _context.הדבקת_פורזץs.FirstOrDefault(c => c.מזהה == הדבקת_פורזץ.מזהה);
            if (existingהדבקת_פורזץ != null)
            {
                _context.Entry(existingהדבקת_פורזץ).CurrentValues.SetValues(הדבקת_פורזץ);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteהדבקת_פורזץ(int id)
        {
            var הדבקת_פורזץToDelete = _context.הדבקת_פורזץs.FirstOrDefault(c => c.מזהה == id);
            if (הדבקת_פורזץToDelete != null)
            {
                _context.הדבקת_פורזץs.Remove(הדבקת_פורזץToDelete);
                _context.SaveChanges();
            }
        }
    }
}
