using System;
using System.Collections.Generic;
using System.Text;

namespace calculos
{
    class Calculadora
    {
        private double numero1;
        private double numero2;

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }

        public double Suma()
        {
            return (numero1 + numero2);
        }

        public double Resta()
        {
            return (numero1 - numero2);
        }
        public double Multiplicacion()
        {
            return (numero1 * numero2);
        }

        public double Division()
        {
            if(numero2 == 0)
            {
                return 0;
            }
            return (numero1 / numero2);
        }
    }
}
