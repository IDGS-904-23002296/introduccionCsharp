using System;
using System.Collections.Generic;
using System.Text;

namespace introduccionCsharpintroduccionCsharp.Models
{
    /*
     *  class [nombre] {
     *  [atributos o variables]
     *  [metodos o funciones]
     */

    class Practica2
    {
        string nombre;
        private int edad;
        protected string carrera;

        public void IngresarDatos()
        {
            Console.WriteLine("Ingresar tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresar tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar tu carrera: ");
            carrera = Console.ReadLine();
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
        }

        static void Main(string[] args)
        {
            Practica2 p2 = new Practica2();
            p2.IngresarDatos();
            p2.MostrarDatos();
        }
    }
}
