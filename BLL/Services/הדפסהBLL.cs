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
    public class הדפסהBLL : IהדפסהBLL
    {
        #region Fields
        private readonly הדפסהDAL _repository;
        private readonly IMapper _mapper;
        #endregion

        #region CRUD Operations

        public הדפסהBLL(הדפסהDAL repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Addהדפסה(הדפסהDto הדפסהDto)
        {
            // המרת DTO ל-Entity ושמירה ב-DAL
            var הדפסהEntity = _mapper.Map<הדפסה>(הדפסהDto);
            _repository.Addהדפסה(הדפסהEntity);
        }

        public הדפסהDto GetהדפסהById(int id)
        {
            var הדפסהEntity = _repository.GetהדפסהById(id);
            return _mapper.Map<הדפסהDto>(הדפסהEntity);

        }

        public List<הדפסהDto> GetAllהדפסהs()
        {
            List<הדפסה> הדפסהEntity = _repository.GetAllהדפסהs();
            return _mapper.Map<List<הדפסהDto>>(הדפסהEntity);

        }

        public void Updateהדפסה(הדפסהDto הדפסהDto)
        {
            // המרת ה-DTO ל-Entity
            var הדפסהEntity = _mapper.Map<הדפסה>(הדפסהDto);

            // קריאה לפונקציית העדכון ב-DAL
            _repository.Updateהדפסה(הדפסהEntity);
        }

        public void Deleteהדפסה(int id)
        {
            _repository.Deleteהדפסה(id);

        }
        #endregion

        #region Calculation Functions

        public double Calculateצדדים(int id)
        {
            var SampleHadpasa = GetהדפסהById(id);
            double result = SampleHadpasa.פרפקטור == true ? Math.Floor(-0.5 * (int)SampleHadpasa.עמודים / (int)SampleHadpasa.עמודיםבצד) / -0.5
            : -((int)-SampleHadpasa.עמודים / (int)SampleHadpasa.עמודיםבצד);
            return result;
        }

        public int Calculateעמודים_בגיליון(int id)
        {
            var SampleHadpasa = GetהדפסהById(id);
            return 2 * (int)SampleHadpasa.עמודיםבצד;
        }
        public double Calculateגליונות_לעותק(int id)
        {
            var SampleHadpasa = GetהדפסהById(id);
            return (int)SampleHadpasa.עמודים / (int)Calculateעמודים_בגיליון(id);

        }

        public double Calculateגליונות_שלמים(int id)
        {
            var SampleHadpasa = GetהדפסהById(id);
            return Math.Floor((double)Calculateגליונות_לעותק(id));

        }

        public double Calculateגיליון_חלקי(int id)
        {
            var SampleHadpasa = GetהדפסהById(id);
            return (double)Calculateגליונות_לעותק(id) - (double)Calculateגליונות_שלמים(id);
        }

        public double Calculateגיליון_חלקי_מעוגל(int id)
        {
            var SampleHadpasa = GetהדפסהById(id);
            double num = (double)Calculateגיליון_חלקי(id);

            return num > 0.5 ? 1 :
                   num > 0.25 ? 0.5 :
                   num > 0.125 ? 0.25 :
                   num > 0.001 ? 0.125 : 0;
        }
        public double Calculateגיליון_חלקי_מעוגל_לפי_הפורמט(int id)
        {
            var SampleHadpasa = GetהדפסהById(id);
            return SampleHadpasa.עמודיםבצד == 8 ? (int)-(-2 * (double)(Calculateגיליון_חלקי_מעוגל(id)) / 2) :
                   SampleHadpasa.עמודיםבצד == 16 ? (int)-(-4 * (double)(Calculateגיליון_חלקי_מעוגל(id)) / 4) :
                   SampleHadpasa.עמודיםבצד == 32 ? (int)-(-8 * (double)(Calculateגיליון_חלקי_מעוגל(id)) / 8) : 888888888888;
        }



        #endregion

    }
}
