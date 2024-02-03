using Array.Logic;
using static System.Console;

var array = new ArrayNew(25);
array.Fill(10, 40);
WriteLine("\t\tArreglo Inicial\n");
WriteLine(array);
WriteLine("\n\t\tArreglo Ordenado por Método Burbuja\n"); 
array.Sort();
WriteLine(array);
WriteLine("\n\t\tArreglo Ordenado por Selección\n"); 
array.SelectionSort();
WriteLine(array);
