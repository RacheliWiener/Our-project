using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iהדבקת_פורזץBLL
    {
        public void Addהדבקת_פורזץ(הדבקת_פורזץDto הדבקת_פורזץDto);
        public הדבקת_פורזץDto Getהדבקת_פורזץById(int id);
        public List<הדבקת_פורזץDto> GetAllהדבקת_פורזץs();
        public void Updateהדבקת_פורזץ(הדבקת_פורזץDto הדבקת_פורזץDto);
        public void Deleteהדבקת_פורזץ(int id);
    }
}
