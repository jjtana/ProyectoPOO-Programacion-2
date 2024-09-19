using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPresentacion
{
    public class Gato : Animal
    {
        public string Color { get; set; }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} el gato maúlla: ¡Miau Miau!");
        }

        public void Saltar()
        {
            Console.WriteLine($"{Nombre} está saltando.");
        }
    }
}
