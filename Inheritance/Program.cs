using System;
using System.Runtime.CompilerServices;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird()
            {
                HasStripes = true,
                HasSpots = false,
                Age = 5,
                Color = "blue-Green stripes",
                CanFly = true,
                IsLarge = false,
                FlyHigh = false,
                TextureOfFeathers = "Smooth"

            };
            Console.WriteLine("-------------------------------------------------------");


            Console.WriteLine("Has stripes: " + bird1.HasStripes);
            Console.WriteLine("Has spots: " + bird1.HasSpots);
            Console.WriteLine("Age: " + bird1.Age);
            Console.WriteLine("Color: " + bird1.Color);
            Console.WriteLine("Can fly: " + bird1.CanFly);
            Console.WriteLine("Is large: " + bird1.IsLarge);
            Console.WriteLine("Flies high: " + bird1.FlyHigh);
            Console.WriteLine("Texture of feathers: " + bird1.TextureOfFeathers);
            Console.WriteLine("-------------------------------------------------------");


            var reptile1 = new Reptile()
            {
                HasStripes = false,
                HasSpots = false,
                Age = 5,
                Color = "green",
                TextureOfScales = "rough",
                IsFast = false,
                HasTail = true,
                NumberOfLegs = 4
            };
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Has stripes: " + reptile1.HasStripes);
            Console.WriteLine("Has spots: " + reptile1.HasSpots);
            Console.WriteLine("Age: " + reptile1.Age);
            Console.WriteLine("Color: " + reptile1.Color);
            Console.WriteLine("Texture of scales: " + reptile1.TextureOfScales);
            Console.WriteLine("Is fast: " + reptile1.IsFast);
            Console.WriteLine("Has tail: " + reptile1.HasTail);
            Console.WriteLine("Number of legs: " + reptile1.NumberOfLegs);
            Console.WriteLine("-------------------------------------------------------");









        }
    }
}
