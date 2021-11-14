using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dwFinal.Models
{
    public class reportes
    {
        public int id { get; set; }
        public int catedraticos_activos { get; set; }
        public int catedraticos_inactivos { get; set; }
        public int catedraticos_reprobados { get; set; }
    }
}
