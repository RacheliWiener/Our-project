using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IהטבעהBLL
    {
        public void Addהטבעה(הטבעהDto הטבעהDto);
        public הטבעהDto GetהטבעהById(int id);
        public List<הטבעהDto> GetAllהטבעהs();
        public void Updateהטבעה(הטבעהDto הטבעהDto);
        public void Deleteהטבעה(int id);
    }
}
