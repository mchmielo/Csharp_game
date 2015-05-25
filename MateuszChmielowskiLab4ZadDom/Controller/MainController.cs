using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Controller
{
    public static class MainController
    {
        /// <summary>
        /// Funkcja zwraca losową szerokość geograficzną w okolicach Wrocławia.
        /// </summary>
        /// <returns></returns>
        public static decimal RandomLatitude()
        {
            Random random = new Random();
            return decimal.Parse((random.Next(510409621, 511621218) / 10000000.0).ToString());
        }
        /// <summary>
        /// Funkcja zwraca losową długość geograficzną w okolicach Wrocławia.
        /// </summary>
        /// <returns></returns>
        public static decimal RandomLongitude()
        {
            Random random = new Random();
            return decimal.Parse((random.Next(1686573028, 1714914321) / 100000000.0).ToString());
            throw new NotImplementedException();
        }
        /// <summary>
        /// Funkcja służy do szyfrowania algorytmem md5.
        /// </summary>
        /// <param name="input">
        /// String do szyfrowania.</param>
        /// <returns>
        /// Zaszyfrowany string.
        /// </returns>
        public static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
 
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Funkcja przelicza nowy punkt na mapie na podstawie punktu początkowego, kąta i odległości.
        /// </summary>
        /// <param name="startingPosition"></param>
        /// <param name="angle"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static PointLatLng NewPosition(PointLatLng startingPosition, double angle, double distance)
        {
            PointLatLng newPosition = new PointLatLng();
            newPosition.Lat = startingPosition.Lat + distance * Math.Cos(Math.PI * angle / 180.0);
            newPosition.Lng = startingPosition.Lng + distance * Math.Sin(Math.PI * angle / 180.0);
            return newPosition;
        }
        /// <summary>
        /// Obliczenie dystansu na podstawie dwóch pozycji GPS.
        /// </summary>
        /// <param name="startPosition"></param>
        /// <param name="endPosition"></param>
        /// <returns></returns>
        public static decimal CalculateDistance(PointLatLng startPosition, PointLatLng endPosition)
        {
            return (decimal)Math.Sqrt(Math.Pow(startPosition.Lat - endPosition.Lat, 2) + Math.Pow(startPosition.Lng - endPosition.Lng, 2));
        }
        /// <summary>
        /// Obliczenie dystansu w metrach na podstawie dwóch pozycji GPS.
        /// </summary>
        /// <param name="startPosition"></param>
        /// <param name="endPosition"></param>
        /// <returns></returns>
        public static decimal CalculateDistanceInMetres(PointLatLng startPosition, PointLatLng endPosition)
        {
            const double earthDiameter = 12756.274;
            double temporary1, temporary2;
            temporary1 = ((endPosition.Lng - startPosition.Lng)*Math.Cos(startPosition.Lat*Math.PI/180));
            temporary2 = (endPosition.Lat - startPosition.Lat);
            return (decimal)((Math.Sqrt(Math.Pow(temporary1, 2) + Math.Pow(temporary2, 2))*Math.PI*earthDiameter/360)/1000);
        }
    }
}
