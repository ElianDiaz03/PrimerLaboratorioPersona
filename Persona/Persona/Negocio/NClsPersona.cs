using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Hablar (ClsPersona persona)
        {
        return " El nombre de la persona es " + persona.Nombre + " y está hablando ";
         

        }
        public String Nacionalidad (ClsPersona persona)
        {
        return " El apellido Garcia " + persona.Apellido+ " Es de nacionalidad" + persona.Nacionalidad + " Española ";

    
        }
        public String Edad(ClsPersona persona)
        {
        return " Minerva tiene la edad de 18 años " + persona.Edad + " y es de nacionalidad Argentina " + persona.Nacionalidad;

        }
        public String edad(ClsPersona persona)
        {
        return " El niño tiene la edad de 8 años " + persona.Edad + " y ya puede hablar 2 idiomas " + persona.Habla;

        }

    }

}
