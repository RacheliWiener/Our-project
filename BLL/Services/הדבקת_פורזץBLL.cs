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
        #region Fields
        private readonly הדבקת_פורזץDAL _repository;
        private readonly IMapper _mapper;

        #endregion

        #region CRUD Operations

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
        #endregion

        #region Calculation Functions

        public int Calculateעותקים_לחיוב(int id)
        {
            var SampleH_F = Getהדבקת_פורזץById(id);
            int result = SampleH_F.עותקים > 700 ? (int)SampleH_F.עותקים : 700;
            return result;

        }

        public double Calculateסהכ_מחיר_הדבקת_פורזץ(int id)
        {
            var SampleH_F = Getהדבקת_פורזץById(id);
            double result = (int)Calculateעותקים_לחיוב(id) * (double)SampleH_F.מחיר;
            return result;
        }
        #endregion

    }
}
