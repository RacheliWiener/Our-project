using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iאריזת_קרטוןDAL 
    {
        public void Addאריזת_קרטון(אריזת_קרטון אריזת_קרטון);

        public אריזת_קרטון Getאריזת_קרטוןById(int id);

        public List<אריזת_קרטון> GetAllאריזת_קרטוןs();

        public void Updateאריזת_קרטון(אריזת_קרטון אריזת_קרטון);

        public void Deleteאריזת_קרטון(int id);
    }
}
