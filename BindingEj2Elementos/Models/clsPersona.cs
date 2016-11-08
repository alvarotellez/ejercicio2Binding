using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingEj2Elementos.Models
{
    public class clsPersona
    {

        //Atributos:
        public int id { get; set; }

        public String nombre { get; set; }

        public String apellido { get; set; }
        public DateTime? fechaNac { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }

        //Constructor por defecto:
        public clsPersona()
        {
            id = 1;
            nombre = "Alvaro";
            apellido = "Tellez";
            fechaNac = DateTime.Today;
            direccion = "Araquil";
            telefono = "656930856";
        }
        //Constructor:
        public clsPersona(int id, String nombre, String apellido, DateTime? fechaNac, String direccion, String telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.direccion = direccion;
            this.telefono = telefono;

        }
    }

}
