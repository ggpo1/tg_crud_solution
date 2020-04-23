using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tg_crud_solution.Models.DataBase;

namespace tg_crud_solution.Services.FounderService
{
    public class FounderService : IFounderService
    {
        public List<Founder> GetFounders()
        {
            List<Founder> _founders = ApplicationDB.db.Founder.ToList();
            return _founders;
        }
    }
}
