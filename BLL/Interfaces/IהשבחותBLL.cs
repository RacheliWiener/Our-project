using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IהשבחותBLL
    {
        public void Addהשבחותה(השבחותDto השבחותDto);
        public השבחותDto GetהשבחותById(int id);
        public List<השבחותDto> GetAllהשבחותs();
        public void Updateהשבחות(השבחותDto השבחותDto);
        public void Deleteהשבחות(int id);
    }
}
