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
        }

        public int N { get; }

        public bool IsFull => _top == N;
        public bool IsEmpty => _top == 0;

        public void Fill(int minimo, int maximo)
        {
            Random random = new Random();

            for (int i =0; i < N; i++) 
            {
                _array[i] = random.Next(minimo, maximo);
             }
            _top = N;
        }
        
        public void Sort()
        {
            for (int i = 0; i < _top - 1; i++)
            {
                for (int j = i + 1 ; j < _top; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        Change(ref _array[i], ref _array[j]);
                    }
                }
                    
            }
        }

        public void Change(ref int v1, ref int v2)
        {
            var aux = v1;
            v1 = v2;
            v2 =aux;
        }

        public void SelectionSort()
        {
            int actual, smaller, j, temp;

            for (actual = 0; actual < _top - 1; actual++)
            {
                smaller = actual;
                for (j = actual + 1; j < _top; j++)
                    if (_array[j] < _array[smaller])
                    {
                        smaller = j;
                    } 
                temp = _array[actual];
                _array[actual] = _array[smaller];
                _array[smaller] = temp;
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


