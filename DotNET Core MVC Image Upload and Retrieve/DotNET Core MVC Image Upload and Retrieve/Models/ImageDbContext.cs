using Microsoft.EntityFrameworkCore;

namespace DotNET_Core_MVC_Image_Upload_and_Retrieve.Models
{
    //File : /Models/ImageDbContext.cs
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        { }

        public DbSet<ImageModel> Images { get; set; }
    }
}
