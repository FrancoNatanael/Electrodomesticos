using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrodomesticosPrograma
{
    class Lavadora : Electrodomestico
    {
        private float carga;

        public Lavadora(float carga,float precioBase, string color, string consumoEnergetico, string peso) :base(precioBase,color,consumoEnergetico,peso)
        {
            this.carga = carga;
        }

        public override float PrecioFinal()
        {
            float precioConConsumoYPeso = base.PrecioFinal();

            if (carga > 30)
                precioConConsumoYPeso += 50;

            return precioConConsumoYPeso;
        }
    }
}
