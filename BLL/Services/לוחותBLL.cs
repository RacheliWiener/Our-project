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
    public class לוחותBLL : IלוחותBLL
    {
        private readonly לוחותDAL _repository;
        private readonly IMapper _mapper;

        public לוחותBLL(לוחותDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addלוח(לוחותDto לוחDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var לוחותEntity = _mapper.Map<לוחות>(לוחDto);
            _repository.Addלוח(לוחותEntity);
        }

        public לוחותDto GetלוחById(int id)
        {
            var לוחותEntity = _repository.GetלוחById(id);
            return _mapper.Map<לוחותDto>(לוחותEntity);

        }

        public List<לוחותDto> GetAllלוחותs()
        {
            List<לוחות> לוחותEntity = _repository.GetAllלוחותs();
            return _mapper.Map<List<לוחותDto>>(לוחותEntity);

        }

        public void Updateלוח(לוחותDto לוחDto)
        {
            // המרת ה-DTO ל-Entity
            var לוחEntity = _mapper.Map<לוחות>(לוחDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateלוח(לוחEntity);
        }

        public void Deleteלוח(int id)
        {
            _repository.Deleteלוח(id);

        }
    }
}
