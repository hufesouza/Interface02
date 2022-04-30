using System;
namespace InterfaceDemo2
{
    public interface IDestroyable
    {
        //Property to store the audio file of destruction sound
        string DestructionSound { get; set; }
        //method to destroy an object

        void Destroy();
    }
}
