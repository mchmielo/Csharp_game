using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class GasStation
    {
        /// <summary>
        /// Funkcja zwraca wszystkie stacje benzynowe.
        /// </summary>
        /// <returns></returns>
        public static List<GasStation> GetAllGasStations()
        {
            return (from gasStation in DatabaseContext.dataContext.GasStations select gasStation).ToList();
        }
        /// <summary>
        /// Funkcja zwraca stację benzynową o podanym id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static GasStation GetGasStationByID(int id)
        {
            return (from gasStation in DatabaseContext.dataContext.GasStations select gasStation).Where(x => x.ID == id).First();
        }
    }
}
