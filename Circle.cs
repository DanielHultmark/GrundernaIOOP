using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaIOOP
{
    internal class Circle
        //Skapade en klass
    {
        private double _radius;
        //Skapade en konstruktor för radien
        public Circle(double radius)
        {
            _radius = radius;            
        }
        //En metod för att räkna ut arean av cirkeln
        public static double GetArea(double radius)
        {            
            return radius * radius * Math.PI;
        }
        


        
    }
}
