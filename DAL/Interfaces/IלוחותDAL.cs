using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IלוחותDAL
    {
        public void Addלוח(לוחות לוח);
        public לוחות GetלוחById(int id);
        public List<לוחות> GetAllלוחותs();
        public void Updateלוח(לוחות לוח);
        public void Deleteלוח(int id);
    }
}
