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
    public class מחירון_הדבקת_פורזץBLL : Iמחירון_הדבקת_פורזץBLL
    {
        private readonly מחירון_הדבקת_פורזץDAL _repository;
        private readonly IMapper _mapper;

        public מחירון_הדבקת_פורזץBLL(מחירון_הדבקת_פורזץDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addמחירון_הדבקת_פורזץה(מחירון_הדבקת_פורזץDto מחירון_הדבקת_פורזץDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var מחירון_הדבקת_פורזץEntity = _mapper.Map<מחירון_הדבקת_פורזץ>(מחירון_הדבקת_פורזץDto);
            _repository.Addמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץEntity);
        }

        public מחירון_הדבקת_פורזץDto Getמחירון_הדבקת_פורזץById(int id)
        {
            var מחירון_הדבקת_פורזץEntity = _repository.Getמחירון_הדבקת_פורזץById(id);
            return _mapper.Map<מחירון_הדבקת_פורזץDto>(מחירון_הדבקת_פורזץEntity);

        }

        public List<מחירון_הדבקת_פורזץDto> GetAllמחירון_הדבקת_פורזץs()
        {
            List<מחירון_הדבקת_פורזץ> מחירון_הדבקת_פורזץEntity = _repository.GetAllמחירון_הדבקת_פורזץs();
            return _mapper.Map<List<מחירון_הדבקת_פורזץDto>>(מחירון_הדבקת_פורזץEntity);

        }

        public void Updateמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץDto מחירון_הדבקת_פורזץDto)
        {
            // המרת ה-DTO ל-Entity
            var מחירון_הדבקת_פורזץEntity = _mapper.Map<מחירון_הדבקת_פורזץ>(מחירון_הדבקת_פורזץDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateמחירון_הדבקת_פורזץ(מחירון_הדבקת_פורזץEntity);
        }

        public void Deleteמחירון_הדבקת_פורזץ(int id)
        {
            _repository.Deleteמחירון_הדבקת_פורזץ(id);

        }
    }
}
