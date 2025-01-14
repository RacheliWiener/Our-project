using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class מחירון_ציפוי_כריכה_קשהDAL
    {
        private readonly WinTechContext _context;

        public מחירון_ציפוי_כריכה_קשהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addמחירון_ציפוי_כריכה_קשה(מחירון_ציפוי_כריכה_קשה מחירון_ציפוי_כריכה_קשה)
        {
            _context.מחירון_ציפוי_כריכה_קשהs.Add(מחירון_ציפוי_כריכה_קשה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public מחירון_ציפוי_כריכה_קשה Getמחירון_ציפוי_כריכה_קשהById(int id)
        {
            return _context.מחירון_ציפוי_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all מחירון_ציפוי_כריכה_קשה)
        public List<מחירון_ציפוי_כריכה_קשה> GetAllמחירון_ציפוי_כריכה_קשהs()
        {
            return _context.מחירון_ציפוי_כריכה_קשהs.ToList();
        }

        // Update
        public void Updateמחירון_ציפוי_כריכה_קשה(מחירון_ציפוי_כריכה_קשה מחירון_ציפוי_כריכה_קשה)
        {
            var existingמחירון_ציפוי_כריכה_קשה = _context.מחירון_ציפוי_כריכה_קשהs.FirstOrDefault(c => c.מזהה == מחירון_ציפוי_כריכה_קשה.מזהה);
            if (existingמחירון_ציפוי_כריכה_קשה != null)
            {
                _context.Entry(existingמחירון_ציפוי_כריכה_קשה).CurrentValues.SetValues(מחירון_ציפוי_כריכה_קשה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteמחירון_ציפוי_כריכה_קשה(int id)
        {
            var מחירון_ציפוי_כריכה_קשהToDelete = _context.מחירון_ציפוי_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
            if (מחירון_ציפוי_כריכה_קשהToDelete != null)
            {
                _context.מחירון_ציפוי_כריכה_קשהs.Remove(מחירון_ציפוי_כריכה_קשהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
