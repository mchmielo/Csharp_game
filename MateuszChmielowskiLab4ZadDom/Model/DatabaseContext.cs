using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public static class DatabaseContext
    {
        public static DataClassesDataContext dataContext;
        static DatabaseContext()
        {
            dataContext = new DataClassesDataContext();
        }
    }
}
