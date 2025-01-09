using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_הדבקת_פורזץDAL
    {
        private readonly WinTechContext _context;

        public מחירון_הדבקת_פורזץDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץ מחירון_הדבקת_פורזץ)
        {
            _context.מחירון_הדבקת_פורזץs.Add(מחירון_הדבקת_פורזץ);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_הדבקת_פורזץ Getמחירון_הדבקת_פורזץById(int id)
        {
            return _context.מחירון_הדבקת_פורזץs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_הדבקת_פורזץ)
        public List<מחירון_הדבקת_פורזץ> GetAllמחירון_הדבקת_פורזץs()
        {
            return _context.מחירון_הדבקת_פורזץs.ToList();
        }

        // Update
        public void Updateמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץ מחירון_הדבקת_פורזץ)
        {
            var existingמחירון_הדבקת_פורזץ = _context.מחירון_הדבקת_פורזץs.FirstOrDefault(c => c.מזהה == מחירון_הדבקת_פורזץ.מזהה);
            if (existingמחירון_הדבקת_פורזץ != null)
            {
                _context.Entry(existingמחירון_הדבקת_פורזץ).CurrentValues.SetValues(מחירון_הדבקת_פורזץ);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_הדבקת_פורזץ(int id)
        {
            var מחירון_הדבקת_פורזץToDelete = _context.מחירון_הדבקת_פורזץs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_הדבקת_פורזץToDelete != null)
            {
                _context.מחירון_הדבקת_פורזץs.Remove(מחירון_הדבקת_פורזץToDelete);
                _context.SaveChanges();
            }
        }
    }
}
