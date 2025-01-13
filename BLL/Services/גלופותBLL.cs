using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class גלופותBLL : IגלופותBLL
    {
        private readonly גלופותDAL _repository;
        private readonly IMapper _mapper;

        public גלופותBLL(גלופותDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addגלופה(גלופותDto גלופהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var גלופהEntity = _mapper.Map<גלופות>(גלופהDto);
            _repository.Addגלופה(גלופהEntity);
        }

        public גלופותDto GetגלופהById(int id)
        {
            var גלופהEntity = _repository.GetגלופהById(id);
            return _mapper.Map<גלופותDto>(גלופהEntity);

        }

        public List<גלופותDto> GetAllגלופותs()
        {
            List<גלופות> גלופותEntity = _repository.GetAllגלופותs();
            return _mapper.Map<List<גלופותDto>>(גלופותEntity);

        }

        public void Updateגלופה(גלופותDto גלופהDto)
        {
            // המרת ה-DTO ל-Entity
            var גלופהEntity = _mapper.Map<גלופות>(גלופהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateגלופה(גלופהEntity);
        }

        public void Deleteגלופה(int id)
        {
            _repository.Deleteגלופה(id);

        }


    }
}

