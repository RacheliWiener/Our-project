using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_ייצור_כריכה_קשהDAL
    {
        private readonly WinTechContext _context;

        public מחירון_ייצור_כריכה_קשהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשה מחירון_ייצור_כריכה_קשה)
        {
            _context.מחירון_ייצור_כריכה_קשהs.Add(מחירון_ייצור_כריכה_קשה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_ייצור_כריכה_קשה Getמחירון_ייצור_כריכה_קשהById(int id)
        {
            return _context.מחירון_ייצור_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_ייצור_כריכה_קשה)
        public List<מחירון_ייצור_כריכה_קשה> GetAllמחירון_ייצור_כריכה_קשהs()
        {
            return _context.מחירון_ייצור_כריכה_קשהs.ToList();
        }

        // Update
        public void Updateמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשה מחירון_ייצור_כריכה_קשה)
        {
            var existingמחירון_ייצור_כריכה_קשה = _context.מחירון_ייצור_כריכה_קשהs.FirstOrDefault(c => c.מזהה == מחירון_ייצור_כריכה_קשה.מזהה);
            if (existingמחירון_ייצור_כריכה_קשה != null)
            {
                _context.Entry(existingמחירון_ייצור_כריכה_קשה).CurrentValues.SetValues(מחירון_ייצור_כריכה_קשה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_ייצור_כריכה_קשה(int id)
        {
            var מחירון_ייצור_כריכה_קשהToDelete = _context.מחירון_ייצור_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_ייצור_כריכה_קשהToDelete != null)
            {
                _context.מחירון_ייצור_כריכה_קשהs.Remove(מחירון_ייצור_כריכה_קשהToDelete);
                _context.SaveChanges();
            }
        }
       
    }
}
