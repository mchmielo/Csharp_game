using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class GasStation
    {
        public static List<GasStation> GetAllGasStations()
        {
            return (from gasStation in DatabaseContext.dataContext.GasStations select gasStation).ToList();
        }
    }
}
