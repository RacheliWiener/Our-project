using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IלקוחותBLL
    {
        public void Addלקוח(לקוחותDto לקוחDto);
        public לקוחותDto GetלקוחById(int id);
        public List<לקוחותDto> GetAllלקוחותs();
        public void Updateלקוח(לקוחותDto לקוחDto);
        public void Deleteלקוח(int id);
    }
}
