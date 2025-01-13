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
    public class הדבקת_פורזץBLL : Iהדבקת_פורזץBLL
    {
        private readonly הדבקת_פורזץDAL _repository;
        private readonly IMapper _mapper;

        public הדבקת_פורזץBLL(הדבקת_פורזץDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהדבקת_פורזץ(הדבקת_פורזץDto הדבקת_פורזץDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var הדבקת_פורזץEntity = _mapper.Map<הדבקת_פורזץ>(הדבקת_פורזץDto);
            _repository.Addהדבקת_פורזץ(הדבקת_פורזץEntity);
        }

        public הדבקת_פורזץDto Getהדבקת_פורזץById(int id)
        {
            var הדבקת_פורזץEntity = _repository.Getהדבקת_פורזץById(id);
            return _mapper.Map<הדבקת_פורזץDto>(הדבקת_פורזץEntity);

        }

        public List<הדבקת_פורזץDto> GetAllהדבקת_פורזץs()
        {
            List<הדבקת_פורזץ> הדבקת_פורזץEntity = _repository.GetAllהדבקת_פורזץs();
            return _mapper.Map<List<הדבקת_פורזץDto>>(הדבקת_פורזץEntity);

        }

        public void Updateהדבקת_פורזץ(הדבקת_פורזץDto הדבקת_פורזץDto)
        {
            // המרת ה-DTO ל-Entity
            var הדבקת_פורזץEntity = _mapper.Map<הדבקת_פורזץ>(הדבקת_פורזץDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהדבקת_פורזץ(הדבקת_פורזץEntity);
        }

        public void Deleteהדבקת_פורזץ(int id)
        {
            _repository.Deleteהדבקת_פורזץ(id);

        }

    }
}
