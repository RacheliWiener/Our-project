using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class קופסא_סטDAL
    {
        private readonly WinTechContext _context;

        public קופסא_סטDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addקופסא_סט(קופסא_סט קופסא_סט)
        {
            _context.קופסא_סטs.Add(קופסא_סט);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public קופסא_סט Getקופסא_סטById(int id)
        {
            return _context.קופסא_סטs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all קופסא_סט)
        public List<קופסא_סט> GetAllקופסא_סטs()
        {
            return _context.קופסא_סטs.ToList();
        }

        // Update
        public void Updateקופסא_סט(קופסא_סט קופסא_סט)
        {
            var existingקופסא_סט = _context.קופסא_סטs.FirstOrDefault(c => c.מזהה == קופסא_סט.מזהה);
            if (existingקופסא_סט != null)
            {
                _context.Entry(existingקופסא_סט).CurrentValues.SetValues(קופסא_סט);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteקופסא_סט(int id)
        {
            var קופסא_סטToDelete = _context.קופסא_סטs.FirstOrDefault(c => c.מזהה == id);
            if (קופסא_סטToDelete != null)
            {
                _context.קופסא_סטs.Remove(קופסא_סטToDelete);
                _context.SaveChanges();
            }
        }
    }
}
