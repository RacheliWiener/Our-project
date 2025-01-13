using AutoMapper;
using DAL.Models;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // הגדרת מיפויים
            CreateMap<אריזת_קרטון, אריזת_קרטוןDto>().ReverseMap();
            CreateMap<גלופות, גלופותDto>().ReverseMap();
            CreateMap<הדבקת_פורזץ, הדבקת_פורזץDto>().ReverseMap();
            CreateMap<הדפסה, הדפסהDto>().ReverseMap();
            CreateMap<הטבעה, הטבעהDto>().ReverseMap();
            CreateMap<הכנת_סטים, הכנת_סטיםDto>().ReverseMap();
            CreateMap<הפקה, הפקהDto>().ReverseMap();
            CreateMap<הצעת_מחיר_הזמנה, הצעת_מחיר_הזמנהDto>().ReverseMap();
            CreateMap<השבחות, השבחותDto>().ReverseMap();
            CreateMap<ייצור_כריכה_קשה, ייצור_כריכה_קשהDto>().ReverseMap();
            CreateMap<לוחות, לוחותDto>().ReverseMap();
            CreateMap<ליין, לייןDto>().ReverseMap();
            CreateMap<לקוחות, לקוחותDto>().ReverseMap();
            CreateMap<מחירון_הדבקת_פורזץ, מחירון_הדבקת_פורזץDto>().ReverseMap();
            CreateMap<מחירון_הדפסה, מחירון_הדפסהDto>().ReverseMap();
            CreateMap<מחירון_הטבעה, מחירון_הטבעהDto>().ReverseMap();
            CreateMap<מחירון_ייצור_כריכה_קשה, מחירון_ייצור_כריכה_קשהDto>().ReverseMap();
        }
    }

}

