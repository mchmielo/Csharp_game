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

        public static decimal RandomLatitude()
        {
            Random random = new Random();
            return decimal.Parse((random.Next(510409621, 511621218) / 10000000.0).ToString());
        }

        public static decimal RandomLongitude()
        {
            Random random = new Random();
            return decimal.Parse((random.Next(1686573028, 1714914321) / 100000000.0).ToString());
            throw new NotImplementedException();
        }

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

        public static PointLatLng NewPosition(PointLatLng startingPosition, double angle, double distance)
        {
            PointLatLng newPosition = new PointLatLng();
            newPosition.Lat = startingPosition.Lat + distance * Math.Cos(Math.PI * angle / 180.0);
            newPosition.Lng = startingPosition.Lng + distance * Math.Sin(Math.PI * angle / 180.0);
            return newPosition;
        }

        public static decimal CalculateDistance(PointLatLng startPosition, PointLatLng endPosition)
        {
            return (decimal)Math.Sqrt(Math.Pow(startPosition.Lat - endPosition.Lat, 2) + Math.Pow(startPosition.Lng - endPosition.Lng, 2));
        }

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
