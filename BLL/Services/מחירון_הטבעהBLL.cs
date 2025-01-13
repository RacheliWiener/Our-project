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
    public class מחירון_הטבעהBLL : Iמחירון_הטבעהBLL
    {
        private readonly מחירון_הטבעהDAL _repository;
        private readonly IMapper _mapper;

        public מחירון_הטבעהBLL(מחירון_הטבעהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addמחירון_הטבעהה(מחירון_הטבעהDto מחירון_הטבעהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var מחירון_הטבעהEntity = _mapper.Map<מחירון_הטבעה>(מחירון_הטבעהDto);
            _repository.Addמחירון_הטבעה(מחירון_הטבעהEntity);
        }

        public מחירון_הטבעהDto Getמחירון_הטבעהById(int id)
        {
            var מחירון_הטבעהEntity = _repository.Getמחירון_הטבעהById(id);
            return _mapper.Map<מחירון_הטבעהDto>(מחירון_הטבעהEntity);

        }

        public List<מחירון_הטבעהDto> GetAllמחירון_הטבעהs()
        {
            List<מחירון_הטבעה> מחירון_הטבעהEntity = _repository.GetAllמחירון_הטבעהs();
            return _mapper.Map<List<מחירון_הטבעהDto>>(מחירון_הטבעהEntity);

        }

        public void Updateמחירון_הטבעה(מחירון_הטבעהDto מחירון_הטבעהDto)
        {
            // המרת ה-DTO ל-Entity
            var מחירון_הטבעהEntity = _mapper.Map<מחירון_הטבעה>(מחירון_הטבעהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateמחירון_הטבעה(מחירון_הטבעהEntity);
        }

        public void Deleteמחירון_הטבעה(int id)
        {
            _repository.Deleteמחירון_הטבעה(id);

        }
    }
}
