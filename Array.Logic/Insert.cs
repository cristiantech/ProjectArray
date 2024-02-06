using System;

namespace MiEspacioDeNombres
{
    public class MatrizLogica
    {
        private int[,] matriz;

        public MatrizLogica(int filas, int columnas)
        {
            matriz = new int[filas, columnas];
        }

        public void Insert(int fila, int columna, int valor)
        {
            if (fila >= 0 && fila < matriz.GetLength(0) && columna >= 0 && columna < matriz.GetLength(1))
            {
                matriz[fila, columna] = valor;
            }
            else
            {
                Console.WriteLine("La posición especificada está fuera de los límites de la matriz.");
            }
        }

        public void ImprimirMatriz()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
    