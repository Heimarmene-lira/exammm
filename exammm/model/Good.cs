using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; } = 0;

        public List<Good_saled> Good_Saled { get; set; }

    }
}
