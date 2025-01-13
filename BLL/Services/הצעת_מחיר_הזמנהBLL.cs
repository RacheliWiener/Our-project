using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class הצעת_מחיר_הזמנהBLL : Iהצעת_מחיר_הזמנהBLL
    {
        private readonly הצעת_מחיר_הזמנהDAL _repository;
        private readonly IMapper _mapper;

        public הצעת_מחיר_הזמנהBLL(הצעת_מחיר_הזמנהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהצעת_מחיר_הזמנהה(הצעת_מחיר_הזמנהDto הצעת_מחיר_הזמנהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var הצעת_מחיר_הזמנהEntity = _mapper.Map<הצעת_מחיר_הזמנה>(הצעת_מחיר_הזמנהDto);
            _repository.Addהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנהEntity);
        }

        public הצעת_מחיר_הזמנהDto Getהצעת_מחיר_הזמנהById(int id)
        {
            var הצעת_מחיר_הזמנהEntity = _repository.Getהצעת_מחיר_הזמנהById(id);
            return _mapper.Map<הצעת_מחיר_הזמנהDto>(הצעת_מחיר_הזמנהEntity);

        }

        public List<הצעת_מחיר_הזמנהDto> GetAllהצעת_מחיר_הזמנהs()
        {
            List<הצעת_מחיר_הזמנה> הצעת_מחיר_הזמנהEntity = _repository.GetAllהצעת_מחיר_הזמנהs();
            return _mapper.Map<List<הצעת_מחיר_הזמנהDto>>(הצעת_מחיר_הזמנהEntity);

        }

        public void Updateהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנהDto הצעת_מחיר_הזמנהDto)
        {
            // המרת ה-DTO ל-Entity
            var הצעת_מחיר_הזמנהEntity = _mapper.Map<הצעת_מחיר_הזמנה>(הצעת_מחיר_הזמנהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהצעת_מחיר_הזמנה(הצעת_מחיר_הזמנהEntity);
        }

        public void Deleteהצעת_מחיר_הזמנה(int id)
        {
            _repository.Deleteהצעת_מחיר_הזמנה(id);

        }
    }
}
