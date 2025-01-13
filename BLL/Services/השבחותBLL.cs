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
    public class השבחותBLL : IהשבחותBLL
    {
        private readonly השבחותDAL _repository;
        private readonly IMapper _mapper;

        public השבחותBLL(השבחותDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהשבחותה(השבחותDto השבחותDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var השבחותEntity = _mapper.Map<השבחות>(השבחותDto);
            _repository.Addהשבחות(השבחותEntity);
        }

        public השבחותDto GetהשבחותById(int id)
        {
            var השבחותEntity = _repository.GetהשבחותById(id);
            return _mapper.Map<השבחותDto>(השבחותEntity);

        }

        public List<השבחותDto> GetAllהשבחותs()
        {
            List<השבחות> השבחותEntity = _repository.GetAllהשבחותs();
            return _mapper.Map<List<השבחותDto>>(השבחותEntity);

        }

        public void Updateהשבחות(השבחותDto השבחותDto)
        {
            // המרת ה-DTO ל-Entity
            var השבחותEntity = _mapper.Map<השבחות>(השבחותDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהשבחות(השבחותEntity);
        }

        public void Deleteהשבחות(int id)
        {
            _repository.Deleteהשבחות(id);

        }
    }
}
