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
    public class הכנת_סטיםBLL : Iהכנת_סטיםBLL
    {
        private readonly הכנת_סטיםDAL _repository;
        private readonly IMapper _mapper;

        public הכנת_סטיםBLL(הכנת_סטיםDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהכנת_סטיםה(הכנת_סטיםDto הכנת_סטיםDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var הכנת_סטיםEntity = _mapper.Map<הכנת_סטים>(הכנת_סטיםDto);
            _repository.Addהכנת_סטים(הכנת_סטיםEntity);
        }

        public הכנת_סטיםDto Getהכנת_סטיםById(int id)
        {
            var הכנת_סטיםEntity = _repository.Getהכנת_סטיםById(id);
            return _mapper.Map<הכנת_סטיםDto>(הכנת_סטיםEntity);

        }

        public List<הכנת_סטיםDto> GetAllהכנת_סטיםs()
        {
            List<הכנת_סטים> הכנת_סטיםEntity = _repository.GetAllהכנת_סטיםs();
            return _mapper.Map<List<הכנת_סטיםDto>>(הכנת_סטיםEntity);

        }

        public void Updateהכנת_סטים(הכנת_סטיםDto הכנת_סטיםDto)
        {
            // המרת ה-DTO ל-Entity
            var הכנת_סטיםEntity = _mapper.Map<הכנת_סטים>(הכנת_סטיםDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהכנת_סטים(הכנת_סטיםEntity);
        }

        public void Deleteהכנת_סטים(int id)
        {
            _repository.Deleteהכנת_סטים(id);

        }
    }
}
