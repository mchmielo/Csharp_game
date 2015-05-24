using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class Car
    {
        public static Car GetCarByID(int id)
        {
            return (from car in DatabaseContext.dataContext.Cars select car).Where(x => x.ID == id).First();
        }
    }
}
