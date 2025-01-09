using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IהשבחותDAL
    {
        public void Addהשבחות(השבחות השבחות);
        public השבחות GetהשבחותById(int id);
        public List<השבחות> GetAllהשבחותs();
        public void Updateהשבחות(השבחות השבחות);
        public void Deleteהשבחות(int id);

    }
}
