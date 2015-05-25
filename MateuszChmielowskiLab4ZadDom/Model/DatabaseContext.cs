using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    /// <summary>
    /// Klasa utworzona po to aby mieć jeden kontekst bazy danych.
    /// </summary>
    public static class DatabaseContext
    {
        /// <summary>
        /// Kontekst bazy danych.
        /// </summary>
        public static DataClassesDataContext dataContext;
        static DatabaseContext()
        {
            dataContext = new DataClassesDataContext();
        }
    }
}
