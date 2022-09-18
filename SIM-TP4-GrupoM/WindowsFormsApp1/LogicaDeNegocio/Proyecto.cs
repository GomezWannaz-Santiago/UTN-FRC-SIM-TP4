using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1.LogicaDeNegocio
{
    internal class Proyecto
    {
        public int cantVueltas { get; set; }
        //public VectorEstados vector { get; set; }

        public double[] Simulacion (int cantidadVueltas, DataGridView dataGrid, Chart grafico)
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

            double A1 = ObtenerRNDUniforme(20,30, rnd.NextDouble());
            double A2 = ObtenerRNDUniforme(30,50, rnd.NextDouble());
            double A3 = ObtenerRNDExponencial(30, rnd.NextDouble());
            double A4 = ObtenerRNDUniforme(10, 20, rnd.NextDouble());
            double A5 = ObtenerRNDExponencial(5, rnd.NextDouble());
            double final = ComprarCaminos(A1,A2,A3,A4,A5);
            int bandera45 = 0;
            
            if (final <= 45)
            {
                bandera45 = 1;
            }



            VectorEstados vector = new VectorEstados() { A1=A1, A2=A2, A3=A3, A4 = A4, A5=A5, Final=final, Max=final, Min=final, Contador45=bandera45, Acumulador=final  };
            dataGrid.Rows.Add(1, Math.Round(A1, 5), Math.Round(A2, 5), Math.Round(A3, 5), Math.Round(A4, 5), Math.Round(A5, 5), Math.Round(final, 5), Math.Round( final), 5);

            for (int i = 1; i < cantidadVueltas; i++)
            {
                A1 = ObtenerRNDUniforme(20, 30, rnd.NextDouble());
                A2 = ObtenerRNDUniforme(30, 50, rnd.NextDouble());
                A3 = ObtenerRNDExponencial(30, rnd.NextDouble());
                A4 = ObtenerRNDUniforme(10, 20, rnd.NextDouble());
                A5 = ObtenerRNDExponencial(5, rnd.NextDouble());

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

                if ((i+1)%muestras == 0)
                {
                    dataGrid.Rows.Add(i+1, Math.Round(A1,5), Math.Round(A2,5), Math.Round(A3, 5), Math.Round(A4, 5), Math.Round(A5, 5), Math.Round(final, 5), Math.Round((vector.Acumulador + final) /(i+1),5));
                    grafico.Series[0].Points.AddXY((double)(i + 1), Math.Round((vector.Acumulador + final) / (i + 1), 5)); //Asigna los valores del eje x (Intervalos) e y (apricion de los numeros en los intervalos) al grafico 

                }

                vector.A1 = A1;
                vector.A2 = A2;
                vector.A3 = A3;
                vector.A4 = A4;
                vector.A5 = A5;
                vector.Final = final;
                vector.Acumulador += final;
            }            

            double[] resultado = new double[4];
            resultado[0] = Math.Round(vector.Max,3);
            resultado[1] = Math.Round(vector.Min,3);
            resultado[2] = Math.Round(vector.Acumulador / cantidadVueltas,3);
            resultado[3] = Math.Round((double)vector.Contador45 / cantidadVueltas,3);
            return resultado;


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
        
        private double ObtenerRNDUniforme(int limInf, int limSup, double rnd)
        {            
            return limInf + rnd * (limSup - limInf);
        }
        private double ObtenerRNDExponencial(double media, double rnd)
        {            
            return (-1 * media) * Math.Log(1 - rnd);             
        }



    }
}
