using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iמחירון_הטבעהDAL
    {
        public void Addמחירון_הטבעה(מחירון_הטבעה מחירון_הטבעה);
        public מחירון_הטבעה Getמחירון_הטבעהById(int id);
        public List<מחירון_הטבעה> GetAllמחירון_הטבעהs();
        public void Updateמחירון_הטבעה(מחירון_הטבעה מחירון_הטבעה);
        public void Deleteמחירון_הטבעה(int id);
    }
}
