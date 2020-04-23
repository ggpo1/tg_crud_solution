using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tg_crud_solution.Models.DataBase
{
    public class Founder
    {
        [Key]
        public int ID { get; set; }
        public string TaxID { get; set; }
        public string FullName { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
