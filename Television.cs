using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrodomesticosPrograma
{
    class Television : Electrodomestico
    {
        private float resolucion;
        private bool sintonizadorTDT;

        public Television(float resolucion, bool sintonizadorTDT, float precioBase, string color, string consumoEnergetico, string peso) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public override float PrecioFinal()
        {
            float precioFinalTv = base.PrecioFinal();

            precioFinalTv += calcularAumentoPorResolucion();

            precioFinalTv += calcularAumentoPorSintonizador();

            return precioFinalTv;
        }

        private float calcularAumentoPorResolucion()
        {
            if (resolucion > 40)
                    return ((base.PrecioFinal() * 30)/100);
            
            return 0;
        }

        private float calcularAumentoPorSintonizador()
        {
            if(sintonizadorTDT)
                return 50;

            return 0;
        }
    }
}
