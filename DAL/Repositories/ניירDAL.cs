using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        
namespace DAL.Repositories
    {
        public class ניירDAL
        {
            private readonly WinTechContext _context;

            public ניירDAL(WinTechContext context)
            {
                _context = context;
            }

            // Create
            public void Addנייר(נייר נייר)
            {
                _context.ניירs.Add(נייר);
                _context.SaveChanges();
            }

            // Read (Get by ID)
            public נייר GetניירById(int id)
            {
                return _context.ניירs.FirstOrDefault(c => c.מזהה == id);
            }

            // Read (Get all customers)
            public List<נייר> GetAllניירs()
            {
                return _context.ניירs.ToList();
            }

            // Update
            public void Updateנייר(נייר נייר)
            {
                var existingנייר = _context.ניירs.FirstOrDefault(c => c.מזהה == נייר.מזהה);
                if (existingנייר != null)
                {
                    _context.Entry(existingנייר).CurrentValues.SetValues(נייר);
                    _context.SaveChanges();
                }
            }

            // Delete
            public void Deleteנייר(int id)
            {
                var ניירToDelete = _context.ניירs.FirstOrDefault(c => c.מזהה == id);
                if (ניירToDelete != null)
                {
                    _context.ניירs.Remove(ניירToDelete);
                    _context.SaveChanges();
                }
            }
        }
    }

