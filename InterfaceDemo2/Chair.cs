using System;
namespace InterfaceDemo2
{
    public class Chair : Furniture, IDestroyable
    {
        //Implementing Interface property
        public string DestructionSound { get; set; }

        //Simple Constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            //Initialize the interface property with a value in the constructor
            DestructionSound = "ChairExplosion.mp3";
        }

        public void Destroy()
        {
            //when a Chair gets destroyed we should play the destruction sound
            //and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed.");
            Console.WriteLine($"Playing destruction sound {DestructionSound}.");
            Console.WriteLine("Spawning chair parts.");
        }
    }
}
