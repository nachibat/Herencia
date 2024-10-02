using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    internal abstract class Personal
    {
        private int id;
        private string nombre;
        private string apellido;

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }

        public Personal(int id, string nombre, string apellido)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public abstract void MostrarDatos();

        public void MostrarNombre()
        {
            Console.WriteLine(this.Nombre);
        }
    }
}
