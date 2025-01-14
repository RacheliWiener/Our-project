using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class קרטון_כריכה_קשהDAL
    {
        private readonly WinTechContext _context;

        public קרטון_כריכה_קשהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addקרטון_כריכה_קשה(קרטון_כריכה_קשה קרטון_כריכה_קשה)
        {
            _context.קרטון_כריכה_קשהs.Add(קרטון_כריכה_קשה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public קרטון_כריכה_קשה Getקרטון_כריכה_קשהById(int id)
        {
            return _context.קרטון_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all קרטון_כריכה_קשה)
        public List<קרטון_כריכה_קשה> GetAllקרטון_כריכה_קשהs()
        {
            return _context.קרטון_כריכה_קשהs.ToList();
        }

        // Update
        public void Updateקרטון_כריכה_קשה(קרטון_כריכה_קשה קרטון_כריכה_קשה)
        {
            var existingקרטון_כריכה_קשה = _context.קרטון_כריכה_קשהs.FirstOrDefault(c => c.מזהה == קרטון_כריכה_קשה.מזהה);
            if (existingקרטון_כריכה_קשה != null)
            {
                _context.Entry(existingקרטון_כריכה_קשה).CurrentValues.SetValues(קרטון_כריכה_קשה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteקרטון_כריכה_קשה(int id)
        {
            var קרטון_כריכה_קשהToDelete = _context.קרטון_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
            if (קרטון_כריכה_קשהToDelete != null)
            {
                _context.קרטון_כריכה_קשהs.Remove(קרטון_כריכה_קשהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
