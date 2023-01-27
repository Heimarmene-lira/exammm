using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public class Good_saled
    {
        public int GoodId { get; set; }
        public Good Good { get; set; } = null!;
        public int SaledId { get; set; }
        public Saled Saled { get; set; } = null!;
    }
}
