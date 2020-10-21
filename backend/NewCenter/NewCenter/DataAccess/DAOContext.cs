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
        DbSet<UserModel> Users { get; set; }
        DbSet<NewsModel> News { get; set; }
        DbSet<CommentModel> Comments { get; set; }
        DbSet<UpvoteModel> Upvotes { get; set; }
        DbSet<BookmarkModel> Bookmarks { get; set; }
        DbSet<PermissionModel> Permissions { get; set; }
        DbSet<SourceModel> Sources { get; set; }
        DbSet<TagModel> Tags { get; set; }
        DbSet<TagedNewsModel> TagedNews { get; set; }


    }
}
