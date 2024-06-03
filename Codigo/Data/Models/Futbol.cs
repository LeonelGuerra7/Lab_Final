using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinalDB.Data.Models
{
    internal class Futbol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Dorsal { get; set; }
        public string Posicion { get; set; }
        public string Sigue { get; set; }


        //Constructor sin parametros
        public Futbol() { }


        //Constructor con parametros
        public Futbol(int id, string nombre, string apellido, int edad, int dorsal, string posicion, string sigue)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dorsal = dorsal;
            Posicion = posicion;
            Sigue = sigue;
          
        }
    }
}