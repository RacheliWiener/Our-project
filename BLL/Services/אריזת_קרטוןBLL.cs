using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class אריזת_קרטוןBLL : Iאריזת_קרטוןBLL
    {
        #region Fields
        private readonly אריזת_קרטוןDAL _repository;
        private readonly IMapper _mapper;

        #endregion

        #region CRUD Operations

        public אריזת_קרטוןBLL(אריזת_קרטוןDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addאריזת_קרטוןה(אריזת_קרטוןDto אריזת_קרטוןDto)
        {
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

            var אריזת_קרטוןEntity = _mapper.Map<אריזת_קרטון>(אריזת_קרטוןDto);
            _repository.Updateאריזת_קרטון(אריזת_קרטוןEntity);
        }

        public void Deleteאריזת_קרטון(int id)
        {
            _repository.Deleteאריזת_קרטון(id);

        }

        #endregion

        #region Calculation Functions
        public double Calculateספרים_בקופסה_משוער(int id)
        {
            var SampleCarton = Getאריזת_קרטוןById(id);
            if (SampleCarton == null || SampleCarton.עמודים < 0 || SampleCarton.ערימותבקופסא == null || SampleCarton.משקלנייר < 0)
                throw new ArgumentException("Invalid input values. All values must be positive.");

            double denominator = 8 + ((int)SampleCarton.עמודים * (int)SampleCarton.משקלנייר * 0.00065);
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator in the calculation cannot be zero.");
            }
            double result = (280 / denominator) * (int)char.GetNumericValue(SampleCarton.ערימותבקופסא.ToString()[0]);

            return (double)Math.Floor(result);



        }
        public double Calculateקופסאות_משוער(int id)
        {
            var SampleCarton = Getאריזת_קרטוןById(id);
            double numOfBooks = Calculateספרים_בקופסה_משוער(id);

            double result = (double)SampleCarton.עותקים / numOfBooks;
            return result;
        }

        public double Calculateסהכ_מחיר_אריזת_קרטון(int id)
        {
            var SampleCarton = Getאריזת_קרטוןById(id);
            double numOfBooks = Calculateקופסאות_משוער(id);
            double result = numOfBooks * (double)SampleCarton.מחיר; 
            return result;

        }

        #endregion
    }
}

