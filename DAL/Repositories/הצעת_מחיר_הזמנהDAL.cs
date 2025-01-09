using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class הצעת_מחיר_הזמנהDAL
    {
        private readonly WinTechContext _context;

        public הצעת_מחיר_הזמנהDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנה הצעת_מחיר_הזמנה)
        {
            _context.הצעת_מחיר_הזמנהs.Add(הצעת_מחיר_הזמנה);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public הצעת_מחיר_הזמנה Getהצעת_מחיר_הזמנהById(int id)
        {
            return _context.הצעת_מחיר_הזמנהs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all הצעת_מחיר_הזמנה)
        public List<הצעת_מחיר_הזמנה> GetAllהצעת_מחיר_הזמנהs()
        {
            return _context.הצעת_מחיר_הזמנהs.ToList();
        }

        // Update
        public void Updateהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנה הצעת_מחיר_הזמנה)
        {
            var existingהצעת_מחיר_הזמנה = _context.הצעת_מחיר_הזמנהs.FirstOrDefault(c => c.מזהה == הצעת_מחיר_הזמנה.מזהה);
            if (existingהצעת_מחיר_הזמנה != null)
            {
                _context.Entry(existingהצעת_מחיר_הזמנה).CurrentValues.SetValues(הצעת_מחיר_הזמנה);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteהצעת_מחיר_הזמנה(int id)
        {
            var הצעת_מחיר_הזמנהToDelete = _context.הצעת_מחיר_הזמנהs.FirstOrDefault(c => c.מזהה == id);
            if (הצעת_מחיר_הזמנהToDelete != null)
            {
                _context.הצעת_מחיר_הזמנהs.Remove(הצעת_מחיר_הזמנהToDelete);
                _context.SaveChanges();
            }
        }
    }
}
