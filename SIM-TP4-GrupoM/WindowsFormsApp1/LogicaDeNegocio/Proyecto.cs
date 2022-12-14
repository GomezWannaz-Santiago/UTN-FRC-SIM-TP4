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

            // AGARRAR LOS 15 PRIMEROS
            // Ordenarlos
            // Armar los intervalos
            // Ir contando las frecuencias dentro del for

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
            double final = CompararCaminos(A1,A2,A3,A4,A5);
            int bandera45 = 0;
            
            if (final <= 45)
            {
                bandera45 = 1;
            }

            double[] limitesIntervalos = new double[14];
            limitesIntervalos[0] = final;
            //Inicializamos el contador con 1 porque como mínimo todos van a tener 1 frec
            int[] contadorFrecuencias = new int[15];
            for (int i = 1; i < contadorFrecuencias.Length; i++)
            {
                contadorFrecuencias[i] = 1;
            }


            VectorEstados vector = new VectorEstados() { A1=A1, A2=A2, A3=A3, A4 = A4, A5=A5, Final=final, Max=final, Min=final, Contador45=bandera45, Acumulador=final };
            vector.SumaVarianza = Math.Pow(vector.Final - vector.Acumulador, 2);
            dataGrid.Rows.Add(1, Math.Round(A1, 5), Math.Round(A2, 5), Math.Round(A3, 5), Math.Round(A4, 5), Math.Round(A5, 5), Math.Round(final, 5), Math.Round( final), 5);

            for (int i = 1; i < cantidadVueltas; i++)
            {
                A1 = ObtenerRNDUniforme(20, 30, rnd.NextDouble());
                A2 = ObtenerRNDUniforme(30, 50, rnd.NextDouble());
                A3 = ObtenerRNDExponencial(30, rnd.NextDouble());
                A4 = ObtenerRNDUniforme(10, 20, rnd.NextDouble());
                A5 = ObtenerRNDExponencial(5, rnd.NextDouble());

                final = CompararCaminos(A1, A2, A3, A4, A5);
                
                //agregar intervalo
                if(i < 14)
                {
                    limitesIntervalos[i] = final;
                    if (i == 13)
                        Array.Sort(limitesIntervalos);
                }
                else
                {
                    bool contado = false;
                    for (int j = 0; j < limitesIntervalos.Length; j++)
                    {
                        if (limitesIntervalos[j] > final)
                        {
                            contadorFrecuencias[j] += 1;
                            contado = true;
                            break;

                        }
                          
                    }

                    if (!contado) // Si no se puso en ningún intervalo, va en el último 
                        contadorFrecuencias[contadorFrecuencias.Length - 1] += 1;

                }

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
                vector.SumaVarianza += Math.Pow(vector.Final - vector.Acumulador / i+1, 2);
            }            



            double[] resultado = new double[5];
            resultado[0] = Math.Round(vector.Max,3);
            resultado[1] = Math.Round(vector.Min,3);
            resultado[2] = Math.Round(vector.Acumulador / cantidadVueltas,3);
            resultado[3] = Math.Round((double)vector.Contador45 / cantidadVueltas,3);
            resultado[4] = CalcularFechaNoventaPorCiento(cantidadVueltas, limitesIntervalos, contadorFrecuencias, vector.Min);            
            return resultado;


        }

        private double CompararCaminos (double A1, double A2, double A3, double A4, double A5)
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

        private double CalcularFechaNoventaPorCiento(int cantidadVueltas, double[] limitesIntervalos, int[] frecuencias, double minimo)
        {
            
            double valorASuperar = cantidadVueltas * 0.9;
            
            int ultimoIntervalo = limitesIntervalos.Length - 1;
            int indice = ultimoIntervalo;
            double limiteInferior = limitesIntervalos[ultimoIntervalo];
            
            int c = 0;
            for (int i = 0; i <= ultimoIntervalo; i++)
            {
                c += frecuencias[i];
                
                if(c >= valorASuperar)
                {
                    limiteInferior = i == 0 ? minimo : limitesIntervalos[i - 1];
                    indice = i;
                    c -= frecuencias[i];
                    break;
                }
            }

            // Dk = Li + ( ( (k* N / 10) - Fi-1) / fi) * (Ls - Li)
            double paso1 = (9 * cantidadVueltas / 10);
            double paso2 = ((paso1 - c) / frecuencias[indice]);
            double paso3 = (limitesIntervalos[indice] - limiteInferior);
            double paso4 = (paso2 * paso3);

            double resultado = limiteInferior + paso4;
            return resultado;

        }

            
    }
}
