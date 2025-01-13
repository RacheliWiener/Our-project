using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iהכנת_סטיםBLL
    {
        public void Addהכנת_סטיםה(הכנת_סטיםDto הכנת_סטיםDto);
        public הכנת_סטיםDto Getהכנת_סטיםById(int id);
        public List<הכנת_סטיםDto> GetAllהכנת_סטיםs();
        public void Updateהכנת_סטים(הכנת_סטיםDto הכנת_סטיםDto);
        public void Deleteהכנת_סטים(int id);

    }
}
