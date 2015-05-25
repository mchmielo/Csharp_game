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

        public static GasStation GetGasStationByID(int id)
        {
            return (from gasStation in DatabaseContext.dataContext.GasStations select gasStation).Where(x => x.ID == id).First();
        }
    }
}
