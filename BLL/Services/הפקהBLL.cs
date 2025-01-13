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
    public class הפקהBLL : IהפקהBLL
    {
        private readonly הפקהDAL _repository;
        private readonly IMapper _mapper;

        public הפקהBLL(הפקהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהפקהה(הפקהDto הפקהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var הפקהEntity = _mapper.Map<הפקה>(הפקהDto);
            _repository.Addהפקה(הפקהEntity);
        }

        public הפקהDto GetהפקהById(int id)
        {
            var הפקהEntity = _repository.GetהפקהById(id);
            return _mapper.Map<הפקהDto>(הפקהEntity);

        }

        public List<הפקהDto> GetAllהפקהs()
        {
            List<הפקה> הפקהEntity = _repository.GetAllהפקותs();
            return _mapper.Map<List<הפקהDto>>(הפקהEntity);

        }

        public void Updateהפקה(הפקהDto הפקהDto)
        {
            // המרת ה-DTO ל-Entity
            var הפקהEntity = _mapper.Map<הפקה>(הפקהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהפקה(הפקהEntity);
        }

        public void Deleteהפקה(int id)
        {
            _repository.Deleteהפקה(id);

        }
    }
}
