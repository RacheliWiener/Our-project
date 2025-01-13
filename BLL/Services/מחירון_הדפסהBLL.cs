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
    public class מחירון_הדפסהBLL : Iמחירון_הדפסהBLL
    {
        private readonly מחירון_הדפסהDAL _repository;
        private readonly IMapper _mapper;

        public מחירון_הדפסהBLL(מחירון_הדפסהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addמחירון_הדפסהה(מחירון_הדפסהDto מחירון_הדפסהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var מחירון_הדפסהEntity = _mapper.Map<מחירון_הדפסה>(מחירון_הדפסהDto);
            _repository.Addמחירון_הדפסה(מחירון_הדפסהEntity);
        }

        public מחירון_הדפסהDto Getמחירון_הדפסהById(int id)
        {
            var מחירון_הדפסהEntity = _repository.Getמחירון_הדפסהById(id);
            return _mapper.Map<מחירון_הדפסהDto>(מחירון_הדפסהEntity);

        }

        public List<מחירון_הדפסהDto> GetAllמחירון_הדפסהs()
        {
            List<מחירון_הדפסה> מחירון_הדפסהEntity = _repository.GetAllמחירון_הדפסהs();
            return _mapper.Map<List<מחירון_הדפסהDto>>(מחירון_הדפסהEntity);

        }

        public void Updateמחירון_הדפסה(מחירון_הדפסהDto מחירון_הדפסהDto)
        {
            // המרת ה-DTO ל-Entity
            var מחירון_הדפסהEntity = _mapper.Map<מחירון_הדפסה>(מחירון_הדפסהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateמחירון_הדפסה(מחירון_הדפסהEntity);
        }

        public void Deleteמחירון_הדפסה(int id)
        {
            _repository.Deleteמחירון_הדפסה(id);

        }
    }
}
