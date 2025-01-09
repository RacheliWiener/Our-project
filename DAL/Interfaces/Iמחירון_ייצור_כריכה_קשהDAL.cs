using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iמחירון_ייצור_כריכה_קשהDAL
    {
        public void Addמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשה מחירון_ייצור_כריכה_קשה);
        public מחירון_ייצור_כריכה_קשה Getמחירון_ייצור_כריכה_קשהById(int id);
        public List<מחירון_ייצור_כריכה_קשה> GetAllמחירון_ייצור_כריכה_קשהs();
        public void Updateמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשה מחירון_ייצור_כריכה_קשה);
        public void Deleteמחירון_ייצור_כריכה_קשה(int id);
    }
}
