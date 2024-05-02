using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto1_ds6.Models
{
    public class Item
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string seg_social { get; set; }
        public string seg_educ { get; set; }
        public double salario { get; set;}
        public double decTerMes { get; set; }

    }
}
