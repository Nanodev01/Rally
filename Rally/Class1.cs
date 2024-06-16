using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rally
{
    internal class Competencia
    {
        private string[] nombres = new string[1000];
        private int[] minutos = new int[1000];
        int contador = 0;

        // Getter and setters: Toma el valor de una variable privada y la devuelve como publica
        // Permite que se puedan ver los valores dentro de otra clase y los muestra de la otra manera cada vez que se mostraban los vectores se volvian a 0 por que se volvian a inicializar
        public string[] Nombres 
        {
            get { return nombres; }
            set { nombres = value; }
            
        }
        public int[] Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }
        public void AgregarCompetidor(string nombres)
        {
            this.nombres[contador] = nombres;
            contador++;
        }
        public void CargarTiempo(int numeroCompetidor, int hh, int mm)
        {
            mm += hh * 60;
            minutos[numeroCompetidor] = mm;

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
                        minutos[i] = minutos[j];
                        minutos[j] = aux;

                        string auxn = nombres[j];
                        nombres[i] = nombres[j];
                        nombres[j] = auxn;

                    }

                }

            }
            
        }
    }
}
