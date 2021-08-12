using System;

namespace Newtech
{
    class Animal
    {   
        
        public string Raza {get; set;}
        public int Edad {get; set;}

        public Animal(string raza, int edad)
        {
            this.Raza = raza;
            this.Edad = edad;
        }
        public void PrintAnimal()
        {
            Console.WriteLine("Raza = " + this.Raza + " || " + "Edad = " + this.Edad);

        }
    }
}
