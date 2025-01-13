using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iמחירון_הדפסהBLL
    {
        public void Addמחירון_הדפסהה(מחירון_הדפסהDto מחירון_הדפסהDto);
        public מחירון_הדפסהDto Getמחירון_הדפסהById(int id);
        public List<מחירון_הדפסהDto> GetAllמחירון_הדפסהs();
        public void Updateמחירון_הדפסה(מחירון_הדפסהDto מחירון_הדפסהDto);
        public void Deleteמחירון_הדפסה(int id);
    }
}
