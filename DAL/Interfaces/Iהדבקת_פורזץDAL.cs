using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iהדבקת_פורזץDAL
    {
        public void Addהדבקת_פורזץ(הדבקת_פורזץ הדבקת_פורזץ);

        public הדבקת_פורזץ Getהדבקת_פורזץById(int id);
        public List<הדבקת_פורזץ> GetAllהדבקת_פורזץs();
        public void Updateהדבקת_פורזץ(הדבקת_פורזץ הדבקת_פורזץ);
        public void Deleteהדבקת_פורזץ(int id);
    }
}
