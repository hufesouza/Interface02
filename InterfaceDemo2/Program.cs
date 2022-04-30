using System;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating 2 object of type chair
            Chair officeChair = new Chair("Brown", "plastic");
            Chair gamingChair = new Chair("white", "wood");

            //creating an object type car
            Car damagedCar = new Car(80f, "black");

            //add those 2 chair to the Idestroyable list of the car
            //so that when we destroy the car the destroyable objects
            //that are nearby will get destroyed
            damagedCar.DestroyableNearby.Add(officeChair);
            damagedCar.DestroyableNearby.Add(gamingChair);

            //Destroy the car
            damagedCar.Destroy();
        }
    }
}
