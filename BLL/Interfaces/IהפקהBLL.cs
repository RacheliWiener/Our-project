using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IהפקהBLL
    {
        public void Addהפקהה(הפקהDto הפקהDto);
        public הפקהDto GetהפקהById(int id);
        public List<הפקהDto> GetAllהפקהs();
        public void Updateהפקה(הפקהDto הפקהDto);
        public void Deleteהפקה(int id);
    }
}
