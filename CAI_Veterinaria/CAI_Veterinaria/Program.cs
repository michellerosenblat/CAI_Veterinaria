using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Rocco", 5, 39, 5);
            Gato gato = new Gato("Gatito", 5, 30, 10);
            Veterinaria miveterinaria = new Veterinaria();
            Console.WriteLine(perro.Nombre + " " + miveterinaria.Diagnosticar(perro));
            Console.WriteLine(gato.Nombre + " " + miveterinaria.Diagnosticar(gato));
            Console.ReadLine();
        }
    }
}
