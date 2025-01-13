using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iמחירון_ייצור_כריכה_קשהBLL
    {
        public void Addמחירון_ייצור_כריכה_קשהה(מחירון_ייצור_כריכה_קשהDto מחירון_ייצור_כריכה_קשהDto);
        public מחירון_ייצור_כריכה_קשהDto Getמחירון_ייצור_כריכה_קשהById(int id);
        public List<מחירון_ייצור_כריכה_קשהDto> GetAllמחירון_ייצור_כריכה_קשהs();
        public void Updateמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשהDto מחירון_ייצור_כריכה_קשהDto);
        public void Deleteמחירון_ייצור_כריכה_קשה(int id);
    }
}
