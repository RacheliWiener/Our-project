using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface Iהצעת_מחיר_הזמנהBLL
    {
        public void Addהצעת_מחיר_הזמנהה(הצעת_מחיר_הזמנהDto הצעת_מחיר_הזמנהDto);
        public הצעת_מחיר_הזמנהDto Getהצעת_מחיר_הזמנהById(int id);
        public List<הצעת_מחיר_הזמנהDto> GetAllהצעת_מחיר_הזמנהs();
        public void Updateהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנהDto הצעת_מחיר_הזמנהDto);
        public void Deleteהצעת_מחיר_הזמנה(int id);
    }
}
