using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model.Repository
{
    public class Repository
    {
        private AppContext context = new AppContext();
        public static Repository Current { get; } = new Repository();
    }
}
