using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Moldels
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        // FKEYS
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
