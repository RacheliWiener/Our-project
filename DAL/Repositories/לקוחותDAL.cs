using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class לקוחותDAL : IלקוחותDAL
    {
        private readonly WinTechContext _context;

        public לקוחותDAL(WinTechContext context)
        {
            _context = context;
        }

        // Create
        public void Addלקוח(לקוחות לקוח)
        {
            _context.לקוחותs.Add(לקוח);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public לקוחות GetלקוחById(int id)
        {
            return _context.לקוחותs.FirstOrDefault(c => c.מזהה == id);
        }

        // Read (Get all customers)
        public List<לקוחות> GetAllלקוחותs()
        {
            return _context.לקוחותs.ToList();
        }

        // Update
        public void Updateלקוח(לקוחות לקוח)
        {
            var existingלקוח = _context.לקוחותs.FirstOrDefault(c => c.מזהה == לקוח.מזהה);
            if (existingלקוח != null)
            {
                _context.Entry(existingלקוח).CurrentValues.SetValues(לקוח);
                _context.SaveChanges();
            }
        }

        // Delete
        public void Deleteלקוח(int id)
        {
            var לקוחToDelete = _context.לקוחותs.FirstOrDefault(c => c.מזהה == id);
            if (לקוחToDelete != null)
            {
                _context.לקוחותs.Remove(לקוחToDelete);
                _context.SaveChanges();
            }
        }
    }
}