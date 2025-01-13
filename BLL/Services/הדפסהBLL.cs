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
    public class הדפסהBLL : IהדפסהBLL
    {
        private readonly הדפסהDAL _repository;
        private readonly IMapper _mapper;

        public הדפסהBLL(הדפסהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהדפסה(הדפסהDto הדפסהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var הדפסהEntity = _mapper.Map<הדפסה>(הדפסהDto);
            _repository.Addהדפסה(הדפסהEntity);
        }

        public הדפסהDto GetהדפסהById(int id)
        {
            var הדפסהEntity = _repository.GetהדפסהById(id);
            return _mapper.Map<הדפסהDto>(הדפסהEntity);

        }

        public List<הדפסהDto> GetAllהדפסהs()
        {
            List<הדפסה> הדפסהEntity = _repository.GetAllהדפסהs();
            return _mapper.Map<List<הדפסהDto>>(הדפסהEntity);

        }

        public void Updateהדפסה(הדפסהDto הדפסהDto)
        {
            // המרת ה-DTO ל-Entity
            var הדפסהEntity = _mapper.Map<הדפסה>(הדפסהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהדפסה(הדפסהEntity);
        }

        public void Deleteהדפסה(int id)
        {
            _repository.Deleteהדפסה(id);

        }

    }
}
