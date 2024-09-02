using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    //poco class (has properties only that present columns)
    internal class Department
    {
        //PK to use in DB
        public int Id { get; set; }
        //to use in view
        public int Code {  get; set; }
        public string Name { get; set; }
        public DateTime Creation { get; set; }
    }
}
