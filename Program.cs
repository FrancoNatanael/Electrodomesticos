using System;
using System.Collections.Generic;

namespace ElectrodomesticosPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico lavadora1 = new Lavadora(40,1000,"blanco","C","medio");
            Lavadora lavadora2 = new Lavadora(20, 350, "azul", "A", "liviano");
            Lavadora lavadora3 = new Lavadora(10, 3400, "blanco", "B", "pesado");
            Lavadora lavadora4 = new Lavadora(100, 120, "blanco", "C", "medio");

            Television tv1  = new Television(50,true, 1000, "blanco", "C", "liviano");
            Television tv2 = new Television(10, false, 200, "blanco", "A", "medio");
            Television tv3 = new Television(80, true, 3504, "blanco", "B", "pesado");
            Television tv4 = new Television(12, false, 100, "blanco", "C", "liviano");
            Television tv5 = new Television(100, false, 2050, "blanco", "A", "medio");
            Television tv6 = new Television(80, true, 354, "blanco", "B", "pesado");

            List<Electrodomestico> listaDeElectrodomesticos = new List<Electrodomestico>();

            listaDeElectrodomesticos.Add(lavadora1);
            listaDeElectrodomesticos.Add(lavadora2);
            listaDeElectrodomesticos.Add(lavadora3);
            listaDeElectrodomesticos.Add(lavadora4);
            listaDeElectrodomesticos.Add(tv1);
            listaDeElectrodomesticos.Add(tv2);
            listaDeElectrodomesticos.Add(tv3);
            listaDeElectrodomesticos.Add(tv4);
            listaDeElectrodomesticos.Add(tv5);
            listaDeElectrodomesticos.Add(tv6);

            foreach(Electrodomestico electrodomestico in listaDeElectrodomesticos)
            {
                Console.WriteLine("El valor del electrodomestico es : " + electrodomestico.PrecioFinal());
            }

        }
    }
}
