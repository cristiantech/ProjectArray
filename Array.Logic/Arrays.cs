using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Logic
{
    public class ArrayNew
    {
        private int[] _array;
        private int _top;

        public ArrayNew(int num)
        {
            _array = new int[num];
            N = num;
            _top = 0;
        }

        public int N { get;  }

        public bool IsFull => _top == N;
        public bool IsEmpty => _top == N;


        /// TAREA MÉTODO FILL, CON PARAMETROS.

        public void Fill(int min, int max)
        {

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                _array[i] = random.Next(min, max);

            }

            _top = N;
        }

        /// TAREA SANTIAGO MÉTODO FILL DE SOBRECARGA, SIN MANDARLE PARAMETROS NÚMEROS ENTRE EL 20 Y 30.

        public class Full
        {
            // Definir un método full de sobrecarga que no recibe parámetros
            public void full()
            {
             // Imprimir números desde el 20 y 30

             for(int i = 20; i <= 30; i++)

                {
                Console.WriteLine(i);
                }
            }
        }



        // Método para obtener los números primos en un array
        static List<int> GetPrimes(int[] array)
        {
            List<int> primes = new List<int>();
            foreach (int num in array)
            {
                if (IsPrime(num) && !primes.Contains(num))
                {
                    primes.Add(num);
                }
            }
            return primes;
        }

        // Método para verificar si un número es primo
        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }


        public void Sort()
        {
            for (int i = 0;i < _top -1;i++)
            {
                for (int j = i + 1; j < _top; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        Change(ref _array[i], _array[j]);
                    }
                }
            }
        }

        private void Change(ref int v1, int v2)
        {
           var aux = v1;
            v1 = v2;
            v2 = aux;
        }

        public override string ToString()
        {
            var output = "";

            if (IsEmpty) { return "Array Empty"; }

            var count = 0;

            for (int i  = 0; i < N; i++)
            {
                if (count == 10)
                {
                    output += "\n";
                    count = 0;
                }

                output += $"{_array[i]}\t";
                count++;
            }

            return output;
        }
    }
}
