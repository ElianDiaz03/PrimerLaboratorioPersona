using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Entidades
{
    class ClsPersona
    {

        // Propiadades de una persona 

        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private string nacionalidad;

        // Acciones de una persona 

        private string habla;
        private string respira;
        private string camina;
        private string observa;
        private string pensa;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Habla { get => habla; set => habla = value; }
        public string Respira { get => respira; set => respira = value; }
        public string Camina { get => camina; set => camina = value; }
        public string Observa { get => observa; set => observa = value; }
        public string Pensa { get => pensa; set => pensa = value; }
    }
}
