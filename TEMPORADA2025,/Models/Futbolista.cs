using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMPORADA2025_.Models
{
    // Models/Futbolista.cs
    public class Futbolista
    {
        public string Identificacion { get; set; }
        public string MombreFutbolista { get; set; }
        public string Equipo { get; set; } // Foreign Key
        public int Edad { get; set; }
        public int Goles { get; set; }
        public string Nacionalidad { get; set; }
        public string Posicion { get; set; }
        public Boolean Lesiones { get; set; }
        // ... other properties
    }
}
