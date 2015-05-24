﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class CarDealer
    {
        public static List<CarDealer> GetAllCarDealers()
        {
            return (from dealer in DatabaseContext.dataContext.CarDealers select dealer).ToList();
        }
    }
}
