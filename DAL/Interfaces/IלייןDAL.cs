using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IלייןDAL
    {
        public void Addליין(ליין ליין);
        public ליין GetלייןById(int id);
        public List<ליין> GetAllלייןs();
        public void Updateליין(ליין ליין);
        public void Deleteליין(int id);
    }
}
