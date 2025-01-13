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
    public class לקוחותBLL : IלקוחותBLL
    {
        private readonly לקוחותDAL _repository;
        private readonly IMapper _mapper;

        public לקוחותBLL(לקוחותDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addלקוח(לקוחותDto לקוחDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var לקוחEntity = _mapper.Map<לקוחות>(לקוחDto);
            _repository.Addלקוח(לקוחEntity);
        }

        public לקוחותDto GetלקוחById(int id)
        {
            var לקוחותEntity = _repository.GetלקוחById(id);
            return _mapper.Map<לקוחותDto>(לקוחותEntity);

        }

        public List<לקוחותDto> GetAllלקוחותs()
        {
            List<לקוחות> לקוחותEntity = _repository.GetAllלקוחותs();
            return _mapper.Map<List<לקוחותDto>>(לקוחותEntity);

        }

        public void Updateלקוח(לקוחותDto לקוחDto)
        {
            // המרת ה-DTO ל-Entity
            var לקוחותEntity = _mapper.Map<לקוחות>(לקוחDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateלקוח(לקוחותEntity);
        }

        public void Deleteלקוח(int id)
        {
            _repository.Deleteלקוח(id);

        }
    }
}
