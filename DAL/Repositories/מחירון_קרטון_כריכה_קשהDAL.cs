using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_קרטון_כריכה_קשהDAL
    {
        private readonly WinTechContext _context;

        public מחירון_קרטון_כריכה_קשהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_קרטון_כריכה_קשה(מחירון_קרטון_כריכה_קשה מחירון_קרטון_כריכה_קשה)
        {
            _context.מחירון_קרטון_כריכה_קשהs.Add(מחירון_קרטון_כריכה_קשה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_קרטון_כריכה_קשה Getמחירון_קרטון_כריכה_קשהById(int id)
        {
            return _context.מחירון_קרטון_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<מחירון_קרטון_כריכה_קשה> GetAllמחירון_קרטון_כריכה_קשהs()
        {
            return _context.מחירון_קרטון_כריכה_קשהs.ToList();
        }

        // Update
        public void Updateמחירון_קרטון_כריכה_קשה(מחירון_קרטון_כריכה_קשהDAL מחירון_קרטון_כריכה_קשה)
        {
            var existingמחירון_קרטון_כריכה_קשה = _context.מחירון_קרטון_כריכה_קשהs.FirstOrDefault(c => c.מזהה == מחירון_קרטון_כריכה_קשה.מזהה);
            if (existingמחירון_קרטון_כריכה_קשה != null)
            {
                _context.Entry(existingמחירון_קרטון_כריכה_קשה).CurrentValues.SetValues(מחירון_קרטון_כריכה_קשה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_קרטון_כריכה_קשה(int id)
        {
            var מחירון_קרטון_כריכה_קשהToDelete = _context.מחירון_קרטון_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_קרטון_כריכה_קשהToDelete != null)
            {
                _context.מחירון_קרטון_כריכה_קשהs.Remove(מחירון_קרטון_כריכה_קשהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
