using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.DAL
{
    public class DALContext: IDALContext
    {
        private HDContext dbContext;
        private IContentRepository contents;
        private INewsCategoryRepository newsCategories;
        private INewsRepository news;
        private IPageRepository pages;
        private IRoleRepository roles;
        private IUserRepository users;

        public IContentRepository Contents 
        {
            get
            {
                if (contents == null)
                    contents = new ContentRepository(dbContext);

                return contents;
            }
        }

        public INewsCategoryRepository NewsCategories
        {
            get
            {
                if (newsCategories == null)
                    newsCategories = new NewsCategoryRepository(dbContext);

                return newsCategories;
            }
        }

        public INewsRepository News
        {
            get
            {
                if (news == null)
                    news = new NewsRepository(dbContext);

                return news;
            }
        }

        public IPageRepository Pages
        {
            get
            {
                if (pages == null)
                    pages = new PageRepository(dbContext);

                return pages;
            }
        }

        public IRoleRepository Roles
        {
            get
            {
                if (roles == null)
                    roles = new RoleRepository(dbContext);

                return roles;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (users == null)
                    users = new UserRepository(dbContext);

                return users;
            }
        }


        public DALContext()
        {
            dbContext = new HDContext();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (contents != null)
                contents.Dispose();
            if (news != null)
                news.Dispose();
            if (newsCategories != null)
                newsCategories.Dispose();
            if (pages != null)
                pages.Dispose();
            if (roles != null)
                roles.Dispose();
            if (users != null)
                users.Dispose();

            if (dbContext != null)
                dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
