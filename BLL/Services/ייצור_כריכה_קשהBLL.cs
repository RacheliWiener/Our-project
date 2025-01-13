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
    public class ייצור_כריכה_קשהBLL : Iייצור_כריכה_קשהBLL
    {
        private readonly ייצור_כריכה_קשהDAL _repository;
        private readonly IMapper _mapper;

        public ייצור_כריכה_קשהBLL(ייצור_כריכה_קשהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addייצור_כריכה_קשהה(ייצור_כריכה_קשהDto ייצור_כריכה_קשהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var ייצור_כריכה_קשהEntity = _mapper.Map<ייצור_כריכה_קשה>(ייצור_כריכה_קשהDto);
            _repository.Addייצור_כריכה_קשה(ייצור_כריכה_קשהEntity);
        }

        public ייצור_כריכה_קשהDto Getייצור_כריכה_קשהById(int id)
        {
            var ייצור_כריכה_קשהEntity = _repository.Getייצור_כריכה_קשהById(id);
            return _mapper.Map<ייצור_כריכה_קשהDto>(ייצור_כריכה_קשהEntity);

        }

        public List<ייצור_כריכה_קשהDto> GetAllייצור_כריכה_קשהs()
        {
            List<ייצור_כריכה_קשה> ייצור_כריכה_קשהEntity = _repository.GetAllייצור_כריכה_קשהs();
            return _mapper.Map<List<ייצור_כריכה_קשהDto>>(ייצור_כריכה_קשהEntity);

        }

        public void Updateייצור_כריכה_קשה(ייצור_כריכה_קשהDto ייצור_כריכה_קשהDto)
        {
            // המרת ה-DTO ל-Entity
            var ייצור_כריכה_קשהEntity = _mapper.Map<ייצור_כריכה_קשה>(ייצור_כריכה_קשהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateייצור_כריכה_קשה(ייצור_כריכה_קשהEntity);
        }

        public void Deleteייצור_כריכה_קשה(int id)
        {
            _repository.Deleteייצור_כריכה_קשה(id);

        }
    }
}
