using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesYClasesAbstractas
{
    internal class Becarios: Empleados, Estudiantes
    {
        private string carrera;
        private string curso;
        private string departamento;

        public Becarios(string nombre, string prApellido, string sgApellido, double sueldoBase, string dni,
            string carrera, string curso, string departamento) 
            : base(nombre, prApellido, sgApellido, sueldoBase, dni)
        {
            this.Carrera = carrera;
            this.Curso = curso;
            this.Departamento = departamento;
        }

        public string Carrera { get => carrera; set => carrera = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Departamento { get => departamento; set => departamento = value; }

        public new string informacion()
        {
            return "Carrera: " + Carrera + "\nDepartamento: " + Departamento; 
        }

        public string Examenes() { return ""; }

        public string Universidad() { return ""; }

        public string NotaMedia() { return ""; }
    }
}
