using informaionUDB.Data.Interface;
using informaionUDB.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace informaionUDB.Data.Repository
{
    public class DocktorRepository : Repository<Docktor>, IDocktorRepository
    {
        public DocktorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
