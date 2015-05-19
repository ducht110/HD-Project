using HDServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.DAL
{
    public class HDInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<HDContext> 
    {
        protected override void Seed(HDContext context)
        {
           
        } 
    }
}
