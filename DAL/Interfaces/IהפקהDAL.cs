using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IהפקהDAL
    {
        public void Addהפקה(הפקה הפקה);
        public הפקה GetהפקהById(int id);
        public List<הפקה> GetAllהפקותs();
        public void Updateהפקה(הפקה הפקה);
        public void Deleteהפקה(int id);
    }
}
