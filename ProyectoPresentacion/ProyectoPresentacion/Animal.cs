using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPresentacion
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}
