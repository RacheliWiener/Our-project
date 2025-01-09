using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iמחירון_הדפסהDAL
    {
        public void Addמחירון_הדפסה(מחירון_הדפסה מחירון_הדפסה);
        public מחירון_הדפסה Getמחירון_הדפסהById(int id);
        public List<מחירון_הדפסה> GetAllמחירון_הדפסהs();
        public void Updateמחירון_הדפסה(מחירון_הדפסה מחירון_הדפסה);
        public void Deleteמחירון_הדפסה(int id);
    }
}
