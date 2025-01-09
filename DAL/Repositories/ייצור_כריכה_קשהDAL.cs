using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ייצור_כריכה_קשהDAL
    {
        private readonly WinTechContext _context;

        public ייצור_כריכה_קשהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addייצור_כריכה_קשה(ייצור_כריכה_קשה ייצור_כריכה_קשה)
        {
            _context.ייצור_כריכה_קשהs.Add(ייצור_כריכה_קשה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public ייצור_כריכה_קשה Getייצור_כריכה_קשהById(int id)
        {
            return _context.ייצור_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all ייצור_כריכה_קשה)
        public List<ייצור_כריכה_קשה> GetAllייצור_כריכה_קשהs()
        {
            return _context.ייצור_כריכה_קשהs.ToList();
        }

        // Update
        public void Updateייצור_כריכה_קשה(ייצור_כריכה_קשה ייצור_כריכה_קשה)
        {
            var existingייצור_כריכה_קשה = _context.ייצור_כריכה_קשהs.FirstOrDefault(c => c.מזהה == ייצור_כריכה_קשה.מזהה);
            if (existingייצור_כריכה_קשה != null)
            {
                _context.Entry(existingייצור_כריכה_קשה).CurrentValues.SetValues(ייצור_כריכה_קשה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteייצור_כריכה_קשה(int id)
        {
            var ייצור_כריכה_קשהToDelete = _context.ייצור_כריכה_קשהs.FirstOrDefault(c => c.מזהה == id);
            if (ייצור_כריכה_קשהToDelete != null)
            {
                _context.ייצור_כריכה_קשהs.Remove(ייצור_כריכה_קשהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
