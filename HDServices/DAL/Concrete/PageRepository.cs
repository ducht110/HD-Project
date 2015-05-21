using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDServices.Models;

namespace HDServices.DAL
{
    public class PageRepository: Repository<Page>, IPageRepository
    {
        public PageRepository(HDContext context) 
            : base()
        {

        }
    }
}
