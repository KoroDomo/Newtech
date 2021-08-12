using System;

namespace Newtech
{
    class Perro : Animal
    {
        string Name {get; set;}
        string Talk {get; set;}
        bool Pedigree {get; set;}
        static int cantidad;

        public Perro(string raza, int edad, string name, bool pedigree) : base(raza, edad)
        {
            this.Name = name;
            this.Talk = "Woof!";
            this.Pedigree = pedigree;
            cantidad++;
        }

        public static void Contador()
        {
            Console.WriteLine("Cantidad de perros creados: " + cantidad);
        }

        public override string ToString()
        {
            return "Name :" + Name +
                    "Raza :" + Raza +
                    "Edad :" + Edad +
                    "Talk :" + Talk +
                    "Pedigree :" + Pedigree;
        }


    }
}