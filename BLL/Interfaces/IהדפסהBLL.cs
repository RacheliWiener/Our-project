using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IהדפסהBLL
    {
        public void Addהדפסה(הדפסהDto הדפסהDto);
        public הדפסהDto GetהדפסהById(int id);
        public List<הדפסהDto> GetAllהדפסהs();
        public void Updateהדפסה(הדפסהDto הדפסהDto);
        public void Deleteהדפסה(int id);
    }
}
