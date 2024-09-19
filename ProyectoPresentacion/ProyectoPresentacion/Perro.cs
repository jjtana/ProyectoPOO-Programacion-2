using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPresentacion
{
    public class Perro : Animal
    {

        public string Raza { get; set; }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} el perro ladra: ¡Guau Guau!");
        }

        public void Correr()
        {
            Console.WriteLine($"{Nombre} está corriendo.");
        }

    }
}
