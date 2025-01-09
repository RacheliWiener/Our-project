using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IלקוחותDAL
    {
        public void Addלקוח(לקוחות לקוח);
        public לקוחות GetלקוחById(int id);
        public List<לקוחות> GetAllלקוחותs();
        public void Updateלקוח(לקוחות לקוח);
        public void Deleteלקוח(int id);

    }
}
