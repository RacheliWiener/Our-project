using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iייצור_כריכה_קשהDAL
    {
        public void Addייצור_כריכה_קשה(ייצור_כריכה_קשה ייצור_כריכה_קשה);
        public ייצור_כריכה_קשה Getייצור_כריכה_קשהById(int id);
        public List<ייצור_כריכה_קשה> GetAllייצור_כריכה_קשהs();
        public void Updateייצור_כריכה_קשה(ייצור_כריכה_קשה ייצור_כריכה_קשה);
        public void Deleteייצור_כריכה_קשה(int id);

    }
}
