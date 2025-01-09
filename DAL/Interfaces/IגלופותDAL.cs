using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IגלופותDAL
    {
        public void Addגלופה(גלופות גלופה);

        public גלופות GetגלופהById(int id);

        public List<גלופות> GetAllגלופותs();

        public void Updateגלופה(גלופות גלופה);

        public void Deleteגלופה(int id);
    }
}
