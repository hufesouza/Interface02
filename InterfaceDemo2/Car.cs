using System;
using System.Collections.Generic;

namespace InterfaceDemo2
{
    public class Car : Vehicle, IDestroyable
    {
        //Implementing Interface property
        public string DestructionSound { get; set; }

        //Creating a new property to store the destroyable objects nearby.
        //When a car gets destroyed it should also destroy nearby objects.
        //this list is of type IDestroyable which means it can store any objects
        //that implement this interface and we can only access the properties and methods in this interface.

        public List<IDestroyable> DestroyableNearby;
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            //Initialize the interface property with a value in the constructor
            DestructionSound = "CarExplosion.mp3";
            //Initialize the list of destroyable objects
            DestroyableNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            //when a car gets destroyed we should play the destruction sound
            //and create a fire effect
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Create fire");

            //Go through each destroyable objec nearby and call its destryable method

            foreach (IDestroyable destroyable in DestroyableNearby)
            {
                destroyable.Destroy();
            }

        }
    }
}
