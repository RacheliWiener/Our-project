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
    public class אריזת_קרטוןBLL : Iאריזת_קרטוןBLL
    {
        private readonly אריזת_קרטוןDAL _repository;
        private readonly IMapper _mapper;

        public אריזת_קרטוןBLL(אריזת_קרטוןDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addאריזת_קרטוןה(אריזת_קרטוןDto אריזת_קרטוןDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var אריזת_קרטוןEntity = _mapper.Map<אריזת_קרטון>(אריזת_קרטוןDto);
            _repository.Addאריזת_קרטון(אריזת_קרטוןEntity);
        }

        public אריזת_קרטוןDto Getאריזת_קרטוןById(int id)
        {
            var אריזת_קרטוןEntity = _repository.Getאריזת_קרטוןById(id);
            return _mapper.Map<אריזת_קרטוןDto>(אריזת_קרטוןEntity);

        }

        public List<אריזת_קרטוןDto> GetAllאריזת_קרטוןs()
        {
            List<אריזת_קרטון> אריזת_קרטוןEntity = _repository.GetAllאריזת_קרטוןs();
            return _mapper.Map<List<אריזת_קרטוןDto>>(אריזת_קרטוןEntity);

        }

        public void Updateאריזת_קרטון(אריזת_קרטוןDto אריזת_קרטוןDto)
        {
            // המרת ה-DTO ל-Entity
            var אריזת_קרטוןEntity = _mapper.Map<אריזת_קרטון>(אריזת_קרטוןDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateאריזת_קרטון(אריזת_קרטוןEntity);
        }

        public void Deleteאריזת_קרטון(int id)
        {
            _repository.Deleteאריזת_קרטון(id);

        }

    }
}
