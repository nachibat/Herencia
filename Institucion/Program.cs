using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesor prof = new Profesor(1, "Jose", "Lopez", "Matematicas");
            
            prof.MostrarDatos();
            prof.MostrarNombre();
            Console.ReadLine();
            
        }
    }
}
