using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.LogicaDeNegocio
{
    internal class Proyecto
    {
        public int cantVueltas { get; set; }
        //public VectorEstados vector { get; set; }

        public void Simulacion (int cantidadVueltas, DataGridView dataGrid)
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

            double A1 = ObtenerRNDUniforme(20,30);
            double A2 = ObtenerRNDUniforme(30,50);
            double A3 = ObtenerRNDExponencial(30);
            double A4 = ObtenerRNDUniforme(10, 20);
            double A5 = ObtenerRNDExponencial(5);
            double final = ComprarCaminos(A1,A2,A3,A4,A5);
            int bandera45 = 0;
            
            if (final <= 45)
            {
                bandera45 = 1;
            }



            VectorEstados vector = new VectorEstados() { A1=A1, A2=A2, A3=A3, A4 = A4, A5=A5, Final=final, Max=final, Min=final, Contador45=bandera45, Acumulador=final  };

            for (int i = 1; i < cantidadVueltas; i++)
            {
                A1 = ObtenerRNDUniforme(20, 30);
                A2 = ObtenerRNDUniforme(30, 50);
                A3 = ObtenerRNDExponencial(30);
                A4 = ObtenerRNDUniforme(10, 20);
                A5 = ObtenerRNDExponencial(5);

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
                    dataGrid.Rows.Add(i, Math.Round(A1,5), Math.Round(A2,5), Math.Round(A3, 5), Math.Round(A4, 5), Math.Round(A5, 5), Math.Round(final, 5), Math.Round((vector.Acumulador + final) / i ),5);
                }

                vector.A1 = A1;
                vector.A2 = A2;
                vector.A3 = A3;
                vector.A4 = A4;
                vector.A5 = A5;
                vector.Final = final;
                vector.Acumulador += final;
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

        private double ObtenerRNDUniforme(int limInf, int limSup)
        {
            var rnd = new Random().NextDouble();
            return limInf + rnd * (limSup - limInf);
        }
        private double ObtenerRNDExponencial(double media)
        {
            var rnd = new Random().NextDouble();
            return (-1 * media) * Math.Log(1 - rnd);             
        }

    }
}
