using System;

namespace MatrizLogica
{
    class MatrizLogica : MatrizLogicaBase
    {
        private int v1;
        private int v2;

        public MatrizLogica(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        static void Main(string[] args)
        {
            MatrizLogica matrizLogica = new(3, 3);

            matrizLogica.Insert(0, 0, 1); // Insertar el valor 1 en la fila 0, columna 0
            matrizLogica.Insert(1, 1, 2); // Insertar el valor 2 en la fila 1, columna 1
            matrizLogica.Insert(2, 2, 3); // Insertar el valor 3 en la fila 2, columna 2

            Console.WriteLine("Matriz:");
            matrizLogica.ImprimirMatriz();

            Console.ReadLine();
        }

        private void ImprimirMatriz()
        {
            throw new NotImplementedException();
        }
    }
}
