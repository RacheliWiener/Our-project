using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iמחירון_הטבעהBLL
    {
        public void Addמחירון_הטבעהה(מחירון_הטבעהDto מחירון_הטבעהDto);
        public מחירון_הטבעהDto Getמחירון_הטבעהById(int id);
        public List<מחירון_הטבעהDto> GetAllמחירון_הטבעהs();

        public void Updateמחירון_הטבעה(מחירון_הטבעהDto מחירון_הטבעהDto);
        public void Deleteמחירון_הטבעה(int id);
    }
}
