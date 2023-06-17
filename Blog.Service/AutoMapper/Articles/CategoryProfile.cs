using AutoMapper;
using libBlog.Entity.DTOs.Articles;
using libBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libBlog.Entity.DTOs.Articles;
using libBlog.Entity.Entities;
using libBlog.Entity.DTOs.Categories;

namespace YoutubeBlog.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CategoryAddDto, Category>().ReverseMap();
        }
    }
}