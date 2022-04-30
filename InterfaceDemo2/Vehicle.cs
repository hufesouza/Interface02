using System;
namespace InterfaceDemo2
{

    //base class for vehicles
    public class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        //default constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        //Simple constructor

        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
