using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IלייןBLL
    {
        public void Addלייןה(לייןDto לייןDto);
        public לייןDto GetלייןById(int id);
        public List<לייןDto> GetAllלייןs();
        public void Updateליין(לייןDto לייןDto);
        public void Deleteליין(int id);
    }
}
