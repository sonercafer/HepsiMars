using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiMarsApp.Models
{
    public class Plateau
    {
        public Plateau(int CoordinateX, int CoordinateY)
        {
            x = CoordinateX;
            y = CoordinateY;
        }

        public int x { get; set; }
        public int y { get; set; } 
       
    }
}
