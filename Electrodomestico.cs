using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrodomesticosPrograma
{
     abstract class Electrodomestico
        {
        protected float precioBase;
        protected string color;
        protected string consumoEnergetico;
        protected string peso;

        public Electrodomestico()
        {
            this.consumoEnergetico = "C";
            this.precioBase = 100;
            this.peso = "medio";
        }

        public Electrodomestico(float precioBase, string color, string consumoEnergetico, string peso)
        {
            this.consumoEnergetico = consumoEnergetico;
            this.precioBase = precioBase;
            this.peso = peso;
            this.color = color;
        }

        public virtual float PrecioFinal()
        {
            float precioFinal = this.precioBase;


            precioFinal += CalcularAumentoSegunConsumoEnergetico();

            precioFinal += CalcularAumentoSegunPeso();


            return precioFinal;
        }

        private float CalcularAumentoSegunConsumoEnergetico()
        {
            

            if (consumoEnergetico == "A")
            {
                return 100;
            }
            else if (consumoEnergetico == "B")
            {
                return 80;
            }
            else if (consumoEnergetico == "C")
            {
                return 60;
            }

            return 0;
        }

        private float CalcularAumentoSegunPeso()
        {
            

            if (peso == "liviano")
            {
                return 10;
            }
            else if (peso == "medio")
            {
               return 50;
            }
            else if (peso == "pesado")
            {
                return 80;
            }

            return 0;
        }
    }
}
