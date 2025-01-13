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
    public class לייןBLL : IלייןBLL
    {
        private readonly לייןDAL _repository;
        private readonly IMapper _mapper;

        public לייןBLL(לייןDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addלייןה(לייןDto לייןDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var לייןEntity = _mapper.Map<ליין>(לייןDto);
            _repository.Addליין(לייןEntity);
        }

        public לייןDto GetלייןById(int id)
        {
            var לייןEntity = _repository.GetלייןById(id);
            return _mapper.Map<לייןDto>(לייןEntity);

        }

        public List<לייןDto> GetAllלייןs()
        {
            List<ליין> לייןEntity = _repository.GetAllלייןs();
            return _mapper.Map<List<לייןDto>>(לייןEntity);

        }

        public void Updateליין(לייןDto לייןDto)
        {
            // המרת ה-DTO ל-Entity
            var לייןEntity = _mapper.Map<ליין>(לייןDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateליין(לייןEntity);
        }

        public void Deleteליין(int id)
        {
            _repository.Deleteליין(id);

        }
    }
}
