using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMNG
{
    class Core
    {
        private static FileMNGEntities2 context;
        public static FileMNGEntities2 Context { get => context ?? (context = new FileMNGEntities2()); }
    }
}
