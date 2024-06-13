using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rally
{
    internal class Competencia
    {
        public string[] nombres = new string[1000];
        public int[] minutos = new int[1000];
        int contador = 0;


        public void AgregarCompetidor(string nombres)
        {
            this.nombres[contador] = nombres;
            contador++;
        }
        public void CargarTiempo(int numeroCompetidor, int hh, int mm)
        {
            mm += hh * 60;
            minutos[numeroCompetidor - 1] = mm;

        }

        public void OrdenListadoPorTiempo()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = 1; j < contador; j++)
                {
                    if (minutos[i] > minutos[j])
                    {
                        int aux = minutos[j];
                        string auxn = nombres[j];
                        minutos[i] = minutos[j];
                        minutos[j] = aux;

                        auxn = nombres[j];
                        nombres[i] = nombres[j];
                        nombres[j] = auxn;

                    }

                }

            }
            
        }
    }
}
