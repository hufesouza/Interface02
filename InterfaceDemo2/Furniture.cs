using System;
namespace InterfaceDemo2
{
    public class Furniture
    {
        //base class for furnitures

        public string Color { get; set; }
        public string Material { get; set; }

        //default constructor
        public Furniture()
        {
            Color = "green";
            Material = "Wood";
        }

        //Simple constructor

        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
