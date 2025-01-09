using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IהדפסהDAL
    {
        public void Addהדפסה(הדפסה הדפסה);
        public הדפסה GetהדפסהById(int id);
        public List<הדפסה> GetAllהדפסהs();
        public void Updateהדפסה(הדפסה הדפסה);
        public void Deleteהדפסה(int id);
    }
}
