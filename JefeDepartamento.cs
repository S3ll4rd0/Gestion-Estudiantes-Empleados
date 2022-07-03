using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesYClasesAbstractas
{
    internal class JefeDepartamento: Cualificados
    {
        private int totalTrabajoCargo;
        private int proyectos;

        public JefeDepartamento(string nombre, string prApellido, string sgApellido, double sueldoBase, string dni, 
            string titulacion, string departamento, double plus, int totalTrabajoCargo, int proyectos) 
            : base(nombre, prApellido, sgApellido, sueldoBase, dni, titulacion, departamento, plus)
        {
            this.TotalTrabajoCargo = totalTrabajoCargo;
            this.Proyectos = proyectos;
        }

        public int TotalTrabajoCargo { get => totalTrabajoCargo; set => totalTrabajoCargo = value; }
        public int Proyectos { get => proyectos; set => proyectos = value; }

        public new string informacion()
        {
            return "Total de trabajos a cargo: " + TotalTrabajoCargo + "\nTotal de proyectos: " + Proyectos;
        }
    }
}
