using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace guia_6
{
    internal class Cliente
    {
        string Nombre, Apellido, NoIdentificacion, Direccion, Telefono;

        public void ingresarDatos()
        {
            Console.WriteLine("Ingrese su nombre: \n");
            Nombre= Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido: \n");
            Apellido= Console.ReadLine();
            Console.WriteLine("Ingrese su numero de identificacion: \n");
            NoIdentificacion= Console.ReadLine();
            Console.WriteLine("Ingrese su direccion: \n");
            Direccion= Console.ReadLine();
            Console.WriteLine("Ingrese su numero de telefono: \n");
            Telefono= Console.ReadLine();
        }
        public void mostrarDatos()
        {
            Console.Write("\n\n====================");
            Console.Write("\nNOMBRE:\t" + Nombre);
            Console.Write("\nAPELLIDO:\t" + Apellido);
            Console.Write("\nIDENTIFICACION:\t" + NoIdentificacion);
            Console.Write("\nDIRECCION:\t" + Direccion);
            Console.Write("\nTELEFONO:\t" + Telefono);
            Console.Write("\n====================\n");
        }




    }
}
