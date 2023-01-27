using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public class Saled
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Sum { get; set; } = 0;
        public int UserId { get; set; }
        public Users Users { get; set; } = null!;
        public List<Good_saled> good_Saled { get; set; }
    }
}
