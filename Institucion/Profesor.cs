using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    internal class Profesor : Personal
    {
        private string materia;

        public Profesor(int id, string nombre, string apellido, string materia) : base(id, nombre, apellido)
        {
            this.Materia = materia;
        }

        public string Materia { get { return this.materia; } set { this.materia = value; } }

        public override void MostrarDatos()
        {
            Console.WriteLine("Id: {0} - Nombre completo: {1} {2} - Materia {3}", this.Id, this.Apellido, this.Nombre, this.Materia);
        }
    }
}
