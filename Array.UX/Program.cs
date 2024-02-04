using Array.Logic;
using static Array.Logic.ArrayNew;
using static System.Console;



// Método con sobrecarga sin parametros
Full fill = new Full();
fill.full();
WriteLine(fill);



// Método sin sobrecarga con parametros

var array = new ArrayNew(10);
array.Fill(10, 40);

// Método Sort

WriteLine(array);
array.Sort();
WriteLine(array);

