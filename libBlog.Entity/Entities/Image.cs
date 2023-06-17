using Blog.Core.Entities;
using libBlog.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBlog.Entity.Entities
{

    public class Image : EntitiesBase
    {
        public Image()
        {

        }
        public Image(string fileName,string fileType, string createdBy)
        {
            FileName = fileName;
            FileType = fileType;
            CreatedBy = createdBy;
        }
    public Guid Id { get; set; }
    public string FileName { get; set; }

    public string FileType { get; set; }

    public ICollection<Article> Articles { get; set; }

    public ICollection<AppUser> Users { get; set; } 


    }
}
