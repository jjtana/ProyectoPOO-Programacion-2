using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPresentacion
{
    public class Pajaro : Animal
    {
        public string TipoDePico { get; set; }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} el pájaro canta: ¡Pío Pío!");
        }

        public void Volar()
        {
            Console.WriteLine($"{Nombre} está volando.");
        }
    }
}
