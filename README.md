# Proyecto PIC - Vectores

## Introducción

Un array es una estructura de datos que contiene una serie de elementos del mismo tipo. En C#, los arrays son objetos y se utilizan para almacenar datos de un tipo particular.

## Declaración de Arrays

Para declarar un array en C#, se utiliza la siguiente sintaxis:

```csharp
tipoDeDato[] nombreDelArray = new tipoDeDato[tamaño];
```
## Benjamin= Busqueda Binaria 
La **búsqueda binaria** es un algoritmo eficiente para encontrar un elemento en una lista ordenada. Funciona dividiendo repetidamente a la mitad la parte de la lista donde podría estar el elemento y comparando el valor buscado con el elemento en el medio. Aquí hay un resumen del proceso.

## Benjamin = Métodos implementar números primos.

## Método para obtener los números primos
Se puede implementar un método para verificar si un número es primo en C# de la siguiente manera:
using System;

class Program
{
    static void Main()
    {
        int numero = 17; // Puedes cambiar este valor según tus necesidades

        if (EsPrimo(numero))
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }

        Console.ReadLine();
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}

En este ejemplo, el método EsPrimo toma un número como argumento y devuelve true si es un número primo y false si no lo es. Se utiliza un bucle for para iterar desde 2 hasta la raíz cuadrada del número, y se verifica si el número es divisible por algún valor en ese rango. Si es divisible por algún número en ese rango, entonces no es primo; de lo contrario, es primo.

Se puede ajustar el valor de la variable numero en el método Main para probar con diferentes números.

## Método para obtener cuales son los números  que no se repiten.
Si deseas encontrar los números que no se repiten en una lista de números, puedes crear un método en C# para lograr esto. Aquí hay un ejemplo simple:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 2, 5, 6, 1, 7 };

        var numerosNoRepetidos = ObtenerNumerosNoRepetidos(numeros);

        Console.WriteLine("Números que no se repiten:");
        foreach (var numero in numerosNoRepetidos)
        {
            Console.Write(numero + " ");
        }

        Console.ReadLine();
    }

    static IEnumerable<int> ObtenerNumerosNoRepetidos(int[] numeros)
    {
        var conteoNumeros = new Dictionary<int, int>();

        // Contar la frecuencia de cada número
        foreach (var numero in numeros)
        {
            if (conteoNumeros.ContainsKey(numero))
            {
                conteoNumeros[numero]++;
            }
            else
            {
                conteoNumeros[numero] = 1;
            }
        }

        // Filtrar los números que solo aparecen una vez
        var numerosNoRepetidos = conteoNumeros.Where(pair => pair.Value == 1).Select(pair => pair.Key);

        return numerosNoRepetidos;
    }
}
En este ejemplo, el método ObtenerNumerosNoRepetidos toma un arreglo de números y utiliza un diccionario (conteoNumeros) para contar la frecuencia de cada número. Luego, filtra los números que solo aparecen una vez y los devuelve como una secuencia.

## Método para obtener cuales son los números  que más se repiten.
Para obtener los números que más se repiten en una lista de números, puedes crear un método en C# que cuente la frecuencia de cada número y luego identifique los que tienen la frecuencia más alta. Aquí tienes un ejemplo:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 2, 5, 6, 1, 7, 2, 3, 4, 4 };

        var numerosMasRepetidos = ObtenerNumerosMasRepetidos(numeros);

        Console.WriteLine("Números que más se repiten:");
        foreach (var numero in numerosMasRepetidos)
        {
            Console.Write(numero + " ");
        }

        Console.ReadLine();
    }

    static IEnumerable<int> ObtenerNumerosMasRepetidos(int[] numeros)
    {
        var conteoNumeros = new Dictionary<int, int>();

        // Contar la frecuencia de cada número
        foreach (var numero in numeros)
        {
            if (conteoNumeros.ContainsKey(numero))
            {
                conteoNumeros[numero]++;
            }
            else
            {
                conteoNumeros[numero] = 1;
            }
        }

        // Encontrar la frecuencia máxima
        int frecuenciaMaxima = conteoNumeros.Values.Max();

        // Filtrar los números que tienen la frecuencia máxima
        var numerosMasRepetidos = conteoNumeros.Where(pair => pair.Value == frecuenciaMaxima).Select(pair => pair.Key);

        return numerosMasRepetidos;
    }
}
En este ejemplo, el método ObtenerNumerosMasRepetidos utiliza un diccionario (conteoNumeros) para contar la frecuencia de cada número. Luego, encuentra la frecuencia máxima y filtra los números que tienen esa frecuencia. Estos números son los que más se repiten en la lista dada.