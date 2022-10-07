using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Circle
    {
        public Circle(double radius)
        {




        }

        public string CalculateCircumference(double radius)
        {
            double calcualted = 2 * Math.PI * radius;
            string formattedCircumference = "The calculated circumfrence is :" + Math.Round(calcualted, 2);

            return formattedCircumference;

        }

        public string CalculateArea(double radius)
        {
            double calcualted = Math.PI * radius * radius;
            string formattedArea = "The calcualted area of your circle is: " + Math.Round(calcualted,2);


            return formattedArea;
        }

    }
}



//Build Specifications:
//Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
//public Circle(double radius)
//public double CalculateCircumference()
//public string CalculateFormattedCircumference()
//public double CalculateArea()
//public string CalculateFormattedArea()
//private string FormatNumber(double x)
//Define a member called radius. This member should be private. 
//Define a property to get access to the class member : Radius
//For the value of pi, use the PI constant of the System.Math class.
//Get the user input, create a Circle object, and display the circumference and area.