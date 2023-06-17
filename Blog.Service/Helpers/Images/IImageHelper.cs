using libBlog.Entity.DTOs.Images;
using libBlog.Entity.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imagetype, string folderName = null);

        void Delete(string imageName);
    }
}
