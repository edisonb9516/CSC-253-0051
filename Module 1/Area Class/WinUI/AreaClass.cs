using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 9/9/21
* CSC 253
* Brandon Edison
* This program is going to use winforms and classes to calculate the area of certain shapes
*/
namespace WinUI
{
    class AreaClass
    {
        
        //create the method for the circle area calculation
        public static double circleArea(double r) {


            return (r * r) * Math.PI;
        
        }
        //create the overloaded methods for the rectangle calculation
        public static double rectangleArea(double l, double w)
        {


            return l * w;

        }
        public static decimal rectangleArea(decimal l, decimal w)
        {


            return l * w;

        }
        //create the method for the cylinder calculation
        public static double cylinderArea(double r, double h)
        {


            return Math.PI * (r * r) * h;

        }

    }
}
