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
    public class הטבעהBLL : IהטבעהBLL
    {
        private readonly הטבעהDAL _repository;
        private readonly IMapper _mapper;

        public הטבעהBLL(הטבעהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהטבעה(הטבעהDto הטבעהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var הטבעהEntity = _mapper.Map<הטבעה>(הטבעהDto);
            _repository.Addהטבעה(הטבעהEntity);
        }

        public הטבעהDto GetהטבעהById(int id)
        {
            var הטבעהEntity = _repository.GetהטבעהById(id);
            return _mapper.Map<הטבעהDto>(הטבעהEntity);

        }

        public List<הטבעהDto> GetAllהטבעהs()
        {
            List<הטבעה> הטבעהEntity = _repository.GetAllהטבעהs();
            return _mapper.Map<List<הטבעהDto>>(הטבעהEntity);

        }

        public void Updateהטבעה(הטבעהDto הטבעהDto)
        {
            // המרת ה-DTO ל-Entity
            var הטבעהEntity = _mapper.Map<הטבעה>(הטבעהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהטבעה(הטבעהEntity);
        }

        public void Deleteהטבעה(int id)
        {
            _repository.Deleteהטבעה(id);

        }

    }
}
