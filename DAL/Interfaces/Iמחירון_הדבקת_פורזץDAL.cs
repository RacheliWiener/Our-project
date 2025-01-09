using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iמחירון_הדבקת_פורזץDAL
    {
        public void Addמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץ מחירון_הדבקת_פורזץ);
        public מחירון_הדבקת_פורזץ Getמחירון_הדבקת_פורזץById(int id);
        public List<מחירון_הדבקת_פורזץ> GetAllמחירון_הדבקת_פורזץs();
        public void Updateמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץ מחירון_הדבקת_פורזץ);
        public void Deleteמחירון_הדבקת_פורזץ(int id);
    }
}
