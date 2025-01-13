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
    public class מחירון_ייצור_כריכה_קשהBLL : Iמחירון_ייצור_כריכה_קשהBLL
    {
        private readonly מחירון_ייצור_כריכה_קשהDAL _repository;
        private readonly IMapper _mapper;

        public מחירון_ייצור_כריכה_קשהBLL(מחירון_ייצור_כריכה_קשהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addמחירון_ייצור_כריכה_קשהה(מחירון_ייצור_כריכה_קשהDto מחירון_ייצור_כריכה_קשהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var מחירון_ייצור_כריכה_קשהEntity = _mapper.Map<מחירון_ייצור_כריכה_קשה>(מחירון_ייצור_כריכה_קשהDto);
            _repository.Addמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשהEntity);
        }

        public מחירון_ייצור_כריכה_קשהDto Getמחירון_ייצור_כריכה_קשהById(int id)
        {
            var מחירון_ייצור_כריכה_קשהEntity = _repository.Getמחירון_ייצור_כריכה_קשהById(id);
            return _mapper.Map<מחירון_ייצור_כריכה_קשהDto>(מחירון_ייצור_כריכה_קשהEntity);

        }

        public List<מחירון_ייצור_כריכה_קשהDto> GetAllמחירון_ייצור_כריכה_קשהs()
        {
            List<מחירון_ייצור_כריכה_קשה> מחירון_ייצור_כריכה_קשהEntity = _repository.GetAllמחירון_ייצור_כריכה_קשהs();
            return _mapper.Map<List<מחירון_ייצור_כריכה_קשהDto>>(מחירון_ייצור_כריכה_קשהEntity);

        }

        public void Updateמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשהDto מחירון_ייצור_כריכה_קשהDto)
        {
            // המרת ה-DTO ל-Entity
            var מחירון_ייצור_כריכה_קשהEntity = _mapper.Map<מחירון_ייצור_כריכה_קשה>(מחירון_ייצור_כריכה_קשהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateמחירון_ייצור_כריכה_קשה(מחירון_ייצור_כריכה_קשהEntity);
        }

        public void Deleteמחירון_ייצור_כריכה_קשה(int id)
        {
            _repository.Deleteמחירון_ייצור_כריכה_קשה(id);

        }
    }
}
