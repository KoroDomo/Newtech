using System;

namespace Newtech
{
    class Animal
    {
        public string Raza {get; set;}
        public int Edad {get; set;}

        public Animal(string pRaza, int pEdad)
        {
            Raza = pRaza;
            Edad = pEdad;
        }
        public void PrintAnimal()
        {
            Console.WriteLine("Raza = " + this.Raza + " || " + "Edad = " + this.Edad);

        }
    }
}