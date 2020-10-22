using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewCenter.Models;

namespace NewCenter.DataAccess
{
    public class DAOContext:DbContext
    {
        public DAOContext(DbContextOptions<DAOContext> options)
        : base(options)
        {
           
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<UpvoteModel> Upvotes { get; set; }
        public DbSet<BookmarkModel> Bookmarks { get; set; }
        public DbSet<PermissionModel> Permissions { get; set; }
        public DbSet<SourceModel> Sources { get; set; }
        public DbSet<TagModel> Tags { get; set; }
        public DbSet<TagedNewsModel> TagedNews { get; set; }


    }
}
