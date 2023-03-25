using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static guia_6.Enfermedad;
using static guia_6.Medicina;

namespace guia_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear las enfermedades
            Enfermedad enfermedad1 = new Enfermedad { Nombre = "Estreñimiento", Medicamentos = new List<Medicina>() };
            Enfermedad enfermedad2 = new Enfermedad { Nombre = "Bronquitis aguda", Medicamentos = new List<Medicina>() };
            Enfermedad enfermedad3 = new Enfermedad { Nombre = "Resfrio común", Medicamentos = new List<Medicina>() };
            Enfermedad enfermedad4 = new Enfermedad { Nombre = "Migraña", Medicamentos = new List<Medicina>() };

            // Agregar medicamentos a cada enfermedad
            enfermedad1.Medicamentos.Add(new Medicina { Nombre = "Citrucel", Tipo = "Pastilla", Cantidad = "180 capsulas", FechaVencimiento = new DateTime(2025, 10, 01), Precio = "$ 26.90" });
            enfermedad1.Medicamentos.Add(new Medicina { Nombre = "Metilnatrexona en marca RELISTOR", Tipo = " Iyeccion", Cantidad = " 0.6 ml de solucion cada 36h", FechaVencimiento = new DateTime(2024, 08, 30), Precio = "$ 37.12 , 1 vial de 12mg/0.6ml" });
            enfermedad1.Medicamentos.Add(new Medicina { Nombre = "Lactulosa", Tipo = " Jarabe", Cantidad = "45ml cada dia", FechaVencimiento = new DateTime(2024,08,01), Precio =" $ 1. 26 la botella de 473ml" });
            enfermedad1.Medicamentos.Add(new Medicina { Nombre = " microlax", Tipo = " microenema (pomada via ectal)", Cantidad = " 1 aplicador de 5ml (usar de 5 a 15 minutos antes de evacuar)", FechaVencimiento = new DateTime(2025,10,11), Precio = " $" });

            enfermedad2.Medicamentos.Add(new Medicina { Nombre = "Naproxeno",Tipo = " Pastilla",Cantidad =" 10 tabletas",FechaVencimiento = new DateTime(2025, 08, 10), Precio = " $ 25.50" });
            enfermedad2.Medicamentos.Add(new Medicina { Nombre = "Ventolin", Tipo = "Iyeccion", Cantidad = "0,5ml cada dia", FechaVencimiento = new DateTime(2024, 06, 25), Precio = " $ 16.83 El frasco de 10ml" });
            enfermedad2.Medicamentos.Add(new Medicina { Nombre = "Salbutamol", Tipo = "Jarabe", Cantidad = "5ml-10mlml cada 8h", FechaVencimiento = new DateTime(2024, 12, 13), Precio = " $ 2.97 el frasco de 10ml" });
            enfermedad2.Medicamentos.Add(new Medicina { Nombre = "Vick VapoRub", Tipo = "Balsamo (Pomada)", Cantidad = " 50g el recipiente, aplicar una ligera capa 3 veces por dia", FechaVencimiento = new DateTime(2026, 11, 09), Precio = " $ 5.79 el tarro de 50g" });


            
            Console.WriteLine("BIENBENIDO A LA FARMACIA INTERACTIVA");
            Cliente cls = new Cliente();
            cls.ingresarDatos();
            cls.mostrarDatos();
            Console.ReadLine();

            Enfermedad er = new Enfermedad();
            er.Medicamentos = new List<Medicina>();
            Console.ReadLine();

        }
        
    }
}
