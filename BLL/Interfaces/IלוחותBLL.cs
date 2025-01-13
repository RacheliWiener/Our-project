using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IלוחותBLL
    {
        public void Addלוח(לוחותDto לוחDto);
        public לוחותDto GetלוחById(int id);
        public List<לוחותDto> GetAllלוחותs();
        public void Updateלוח(לוחותDto לוחDto);
        public void Deleteלוח(int id);
    }
}
