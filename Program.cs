using System;

namespace Newtech
{
    class Animal
    {
        public string Raza {get; set;}
        public int Edad {get; set;}
        //el constructor acepta los valores ya que permite la creacion del objeto, pero no retorna los valores de la variables al
        // momento de llmar la funcion PrintAnimal();
        public Animal(string pRaza, int pEdad)
        {
            Raza = pRaza;
            Edad = pEdad;
        }
        public void PrintAnimal()
        {
            Console.WriteLine("Raza = " + Raza + " || " + "Edad = " + Edad);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Linea donde se crea el objeto y se le asigna los valores
            Animal a = new Animal("cosa", 13);

            a.PrintAnimal();
        }
    }
}
