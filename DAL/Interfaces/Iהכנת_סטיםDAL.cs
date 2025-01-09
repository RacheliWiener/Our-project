using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iהכנת_סטיםDAL
    {
        public void Addהכנת_סטים(הכנת_סטים הכנת_סטים);
        public הכנת_סטים Getהכנת_סטיםById(int id);
        public List<הכנת_סטים> GetAllהכנת_סטיםs();
        public void Updateהכנת_סטים(הכנת_סטים הכנת_סטים);
        public void Deleteהכנת_סטים(int id);
    }
}
