using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tg_crud_solution.Models.DataBase;

namespace tg_crud_solution.ViewModels
{
    public class FounderViewModel
    {
        public string Title { get; set; }
        public List<Founder> Founders { get; set; }
    }
}
