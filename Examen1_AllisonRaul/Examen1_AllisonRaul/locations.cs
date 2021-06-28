using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen1_AllisonRaul
{
    public class locations
    {
       
        public int latitud { get; set; }

        public string longitud { get; set; }

        public string ubicorta { get; set; }



    }

    internal class SQLiteAttribute : Attribute
    {
    }
}