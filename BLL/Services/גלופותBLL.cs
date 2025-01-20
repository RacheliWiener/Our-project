using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class גלופותBLL : IגלופותBLL
    {

        #region Fields
        private readonly גלופותDAL _repository;
        private readonly IMapper _mapper;

        public גלופותBLL(גלופותDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        # region CRUD Operations

        public void Addגלופה(גלופותDto גלופהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var גלופהEntity = _mapper.Map<גלופות>(גלופהDto);
            _repository.Addגלופה(גלופהEntity);
        }

        public גלופותDto GetגלופהById(int id)
        {
            var גלופהEntity = _repository.GetגלופהById(id);
            return _mapper.Map<גלופותDto>(גלופהEntity);

        }

        public List<גלופותDto> GetAllגלופותs()
        {
            List<גלופות> גלופותEntity = _repository.GetAllגלופותs();
            return _mapper.Map<List<גלופותDto>>(גלופותEntity);

        }

        public void Updateגלופה(גלופותDto גלופהDto)
        {
            // המרת ה-DTO ל-Entity
            var גלופהEntity = _mapper.Map<גלופות>(גלופהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateגלופה(גלופהEntity);
        }

        public void Deleteגלופה(int id)
        {
            _repository.Deleteגלופה(id);

        }
        #endregion

        #region Calculation Functions
        public int Calculateסנטימטר_רבוע(int id)
        {
            var SampleGlufa = GetגלופהById(id);
            int result = (int)SampleGlufa.אורך * (int)SampleGlufa.רוחב;
            return result;
        }

        public double Calculateסהכ_מחיר_גלופות(int id)
        {
            var SampleGlufa = GetגלופהById(id);
            double result = (double)SampleGlufa.מחיר * (int)Calculateסנטימטר_רבוע(id);
            return result;
        }
        #endregion


    }
}

