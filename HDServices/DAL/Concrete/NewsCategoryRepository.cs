using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDServices.Models;

namespace HDServices.DAL
{
    public class NewsCategoryRepository: Repository<NewsCategory>, INewsCategoryRepository
    {
        public NewsCategoryRepository(HDContext context)
            : base()
        {

        }
    }
}
