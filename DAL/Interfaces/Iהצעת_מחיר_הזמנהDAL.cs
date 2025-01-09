using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Iהצעת_מחיר_הזמנהDAL
    {
        public void Addהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנה הצעת_מחיר_הזמנה);
        public הצעת_מחיר_הזמנה Getהצעת_מחיר_הזמנהById(int id);
        public List<הצעת_מחיר_הזמנה> GetAllהצעת_מחיר_הזמנהs();
        public void Updateהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנה הצעת_מחיר_הזמנה);
        public void Deleteהצעת_מחיר_הזמנה(int id);

    }
}
