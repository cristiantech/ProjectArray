using System;
using System.Collections.Generic;
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

        public int N { get; }

        public bool IsFull => _top == N;
        public bool IsEmpty => _top == 0;

        public void Fill(int minimo, int maximo) {

            Random random = new Random();

            for(int i = 0; i < N; i++) 
            {
                _array[i] = random.Next(minimo, maximo);
            }
            _top = N;
        }

      
        private void Change(ref int v1, ref int v2)
        {
            var aux = v1;
            v1 = v2;
            v2 = aux;
        }
        public void Delete(int index)
        {
            if (!IsEmpty && index >= 0 && index < _top)
            {
                for (int i = index; i < _top - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _top--;
                // Que debo poner como reemplazo del último elemento? 0 o repetir el último de la serie
                _array[_top] = 0;
            }
        }
        public override string ToString()
        {
            var output = "";

            if (IsEmpty) { return "Array Empty"; }

            var count = 0;
            for (int i = 0; i < N; i++)
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

