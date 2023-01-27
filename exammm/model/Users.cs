using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Male { get; set; } = 0;
        public int Age { get; set; } = 0;
        public List<Saled> Saled { get; set; }
    }
}
