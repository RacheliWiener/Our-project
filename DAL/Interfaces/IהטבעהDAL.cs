using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IהטבעהDAL
    {
        public void Addהטבעה(הטבעה הטבעה);
        public הטבעה GetהטבעהById(int id);
        public List<הטבעה> GetAllהטבעהs();
        public void Updateהטבעה(הטבעה הטבעה);
        public void Deleteהטבעה(int id);
    }
}
