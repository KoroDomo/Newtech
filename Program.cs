using System;

namespace Newtech
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Perro p = new Perro("Doberman", 5, "Bobby", true);
            Perro p2 = new Perro("Chihuahua", 3, "Fifi", false);

            Console.WriteLine(p.ToString());
            Perro.Contador();
            
            
        }
    }
}
