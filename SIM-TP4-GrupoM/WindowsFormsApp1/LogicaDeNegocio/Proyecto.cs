using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.LogicaDeNegocio
{
    internal class Proyecto
    {
        public int cantVueltas { get; set; }
        //public VectorEstados vector { get; set; }

        public void Simulacion (int cantidadVueltas)
        {
            int muestras;
            Random rnd = new Random();
            
            if (cantidadVueltas > 100) 
            {
                muestras = cantidadVueltas/50;
            }
            else
            {
                muestras = 1;
            }


            double A1 = rnd.NextDouble();
            double A2 = rnd.NextDouble();
            double A3 = rnd.NextDouble();
            double A4 = rnd.NextDouble();
            double A5 = rnd.NextDouble();
            double final = ComprarCaminos(A1,A2,A3,A4,A5);
            int bandera45 = 0;
            
            if (final <= 45)
            {
                bandera45 = 1;
            }

            VectorEstados vector = new VectorEstados() { A1=A1, A2=A2, A3=A3, A4 = A4, A5=A5, Final=final, Max=final, Min=final, Contador45=bandera45, Acumulador=final  };

            for (int i = 1; i < cantidadVueltas; i++)
            {
                A1 = rnd.NextDouble();
                A2 = rnd.NextDouble();
                A3 = rnd.NextDouble();
                A4 = rnd.NextDouble();
                A5 = rnd.NextDouble();
                final = ComprarCaminos(A1, A2, A3, A4, A5);
                
                if (final <= 45)
                {
                    vector.Contador45++;
                }

                if (final < vector.Min)
                {
                    vector.Min = final;
                }
                else if (final > vector.Max)
                {
                    vector.Max = final;
                }

                if (i%muestras == 0)
                {

                }

                vector.A1 = A1;
                vector.A2 = A2;
                vector.A3 = A3;
                vector.A4 = A4;
                vector.A5 = A5;
                vector.Final = final;
                vector.Acumulador = vector.Acumulador + final;
            }
        }

        private double ComprarCaminos (double A1, double A2, double A3, double A4, double A5)
        {
            double R1;
            
            if (A1+A4 < A2)
            {
                R1 = A2 + A5;
            }
            else
            {
                R1 = A1 + A4 + A5;
            }

            if(R1 < A3)
            {
                return A3;
            }
            else
            {
                return R1;
            }
        }

    }
}
