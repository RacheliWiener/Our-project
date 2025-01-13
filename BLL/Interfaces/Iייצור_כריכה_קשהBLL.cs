using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iייצור_כריכה_קשהBLL
    {
        public void Addייצור_כריכה_קשהה(ייצור_כריכה_קשהDto ייצור_כריכה_קשהDto);
        public ייצור_כריכה_קשהDto Getייצור_כריכה_קשהById(int id);
        public List<ייצור_כריכה_קשהDto> GetAllייצור_כריכה_קשהs();
        public void Updateייצור_כריכה_קשה(ייצור_כריכה_קשהDto ייצור_כריכה_קשהDto);
        public void Deleteייצור_כריכה_קשה(int id);
    }
}
