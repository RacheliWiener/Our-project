using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iאריזת_קרטוןBLL
    {
        public void Addאריזת_קרטוןה(אריזת_קרטוןDto אריזת_קרטוןDto);
        public אריזת_קרטוןDto Getאריזת_קרטוןById(int id);
        public List<אריזת_קרטוןDto> GetAllאריזת_קרטוןs();
        public void Updateאריזת_קרטון(אריזת_קרטוןDto אריזת_קרטוןDto);
        public void Deleteאריזת_קרטון(int id);
    }
}
