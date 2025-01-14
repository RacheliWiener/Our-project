using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ציפוי_כריכה_קשהDAL
    {
        private readonly WinTechContext _context;

        public ציפוי_כריכה_קשהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addציפוי_כריכה_קשה(ציפוי_כריכה_קשה ציפוי_כריכה_קשה)
        {
            _context.ציפוי_כריכה_קשהs.Add(ציפוי_כריכה_קשה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public ציפוי_כריכה_קשה Getציפוי_כריכה_קשהById(int id)
        {
            return _context.ציפוי_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<ציפוי_כריכה_קשה> GetAllציפוי_כריכה_קשהs()
        {
            return _context.ציפוי_כריכה_קשהs.ToList();
        }

        // Update
        public void Updateציפוי_כריכה_קשה(ציפוי_כריכה_קשה ציפוי_כריכה_קשה)
        {
            var existingציפוי_כריכה_קשה = _context.ציפוי_כריכה_קשהs.FirstOrDefault(c => c.מזהה == ציפוי_כריכה_קשה.מזהה);
            if (existingציפוי_כריכה_קשה != null)
            {
                _context.Entry(existingציפוי_כריכה_קשה).CurrentValues.SetValues(ציפוי_כריכה_קשה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteציפוי_כריכה_קשה(int id)
        {
            var ציפוי_כריכה_קשהToDelete = _context.ציפוי_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
            if (ציפוי_כריכה_קשהToDelete != null)
            {
                _context.ציפוי_כריכה_קשהs.Remove(ציפוי_כריכה_קשהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
