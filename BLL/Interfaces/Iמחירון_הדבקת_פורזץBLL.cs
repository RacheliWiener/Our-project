using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iמחירון_הדבקת_פורזץBLL
    {
        public void Addמחירון_הדבקת_פורזץה(מחירון_הדבקת_פורזץDto מחירון_הדבקת_פורזץDto);
        public מחירון_הדבקת_פורזץDto Getמחירון_הדבקת_פורזץById(int id);
        public List<מחירון_הדבקת_פורזץDto> GetAllמחירון_הדבקת_פורזץs();
        public void Updateמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץDto מחירון_הדבקת_פורזץDto);
        public void Deleteמחירון_הדבקת_פורזץ(int id);
    }
}
