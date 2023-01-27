using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public static class Single
    {
        public static AppDB AppDB { get; set; }
        static Single()
        {
            AppDB = new AppDB();
        }
    }
}
