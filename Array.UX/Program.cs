using Array.Logic;
using static System.Console;

var array = new ArrayNew(10);
array.Fill(10, 40);
WriteLine(array);

array.Delete(2);
WriteLine("Array after deletion at index 2:");
WriteLine(array);

