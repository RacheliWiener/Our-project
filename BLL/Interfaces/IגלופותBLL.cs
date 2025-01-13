using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IגלופותBLL
    {
        public void Addגלופה(גלופותDto גלופהDto);
        public גלופותDto GetגלופהById(int id);
        public List<גלופותDto> GetAllגלופותs();
        public void Updateגלופה(גלופותDto גלופהDto);
        public void Deleteגלופה(int id);
    }
}
