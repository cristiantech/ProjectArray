# Proyecto PIC - Vectores

## Introducción

Un array es una estructura de datos que contiene una serie de elementos del mismo tipo. En C#, los arrays son objetos y se utilizan para almacenar datos de un tipo particular.

## Declaración de Arrays

Para declarar un array en C#, se utiliza la siguiente sintaxis:



```csharp
tipoDeDato[] nombreDelArray = new tipoDeDato[tamaño];
```

## Santiago => Fill array sin parametros:

En C#, el método Fill se utiliza para asignar un valor específico a cada elemento de una parte o la totalidad de un array. Existen dos versiones del método Fill: una con sobrecarga y otra sin sobrecarga.

## Santiago => Arrays Método Fill con sobrecarga sin parametros 

```csharp
Array.Fill(array, value);
```

En esta versión, el método Fill toma un array y un valor como argumentos. Cada elemento del array se establecerá con el valor proporcionado. Es útil para inicializar un array completo con un valor específico.

Ejemplo:

```csharp
int[] numeros = new int[5];
Array.Fill(numeros, 42);

// Después de la ejecución, 'numeros' será {42, 42, 42, 42, 42}
```
Método Fill sin Sobrecarga:

```csharp
    Array.Fill(array, value, startIndex, count);
```
En esta versión, además del array y el valor, se proporcionan dos argumentos adicionales: startIndex y count. Estos indican la posición de inicio y la cantidad de elementos a los que se les asignará el valor.
**Ejemplo:**
```csharp
int[] numeros = {1, 2, 3, 4, 5};
Array.Fill(numeros, 0, 1, 3);

// Después de la ejecución, 'numeros' será {1, 0, 0, 0, 5}
```
**En ambos casos, el método Fill ofrece una manera conveniente de establecer rápidamente los valores de un array, ya sea en su totalidad o solo en una parte específica.**

**Arreglos en C#**
Publicado en 31 Dic 2017 el 6:07 pm.
Escrito por Ivan Cachicatari    

Los arreglos en C# (también conocidos como Arrays) al igual que en C/C++, son indexados iniciando en cero (0). La forma de trabajo es muy similar a la mayoría de lenguajes pero hay lagunas diferencias que notarán.


Como declarar un arreglo en C#
Cuando vayamos a declarar un arreglo en debemos colocar los corchetes después de tipo de dato. En C/C++ se estila poner los corchetes después del identificador, eso causa un error de compilación en C#.


## TAREA

## Uso y Manipulación de Arrays (NUMEROS PRIMOS):

Un array es una estructura de datos que permite almacenar elementos del mismo tipo en una secuencia contigua de memoria. En la mayoría de los lenguajes de programación, los arrays son herramientas fundamentales para almacenar y manipular conjuntos de datos.

**Método para Obtener Números Primos**:
Los números primos son aquellos que solo tienen dos divisores: 1 y ellos mismos. Aquí hay un ejemplo de un método para obtener números primos utilizando un array:

``` csharp

using System;
using System.Collections.Generic;

class Program
{
    static List<int> ObtenerPrimos(int n)
    {
        List<int> primos = new List<int>();
        for (int num = 2; num <= n; num++)
        {
            bool esPrimo = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                primos.Add(num);
            }
        }
        return primos;
    }

    static void Main()
    {
        int limite = 50;
        List<int> primosEnLimite = ObtenerPrimos(limite);
        
        Console.WriteLine("Números primos hasta " + limite + ":");
        foreach (int primo in primosEnLimite)
        {
            Console.Write(primo + " ");
        }
    }
}

Método para Obtener Números que no se Repiten en C#:

using System;
using System.Collections.Generic;

class Program
{
    static List<int> NoSeRepiten(List<int> array)
    {
        List<int> noRepetidos = new List<int>();
        HashSet<int> elementosUnicos = new HashSet<int>();

        foreach (int num in array)
        {
            if (elementosUnicos.Add(num))
            {
                noRepetidos.Add(num);
            }
        }

        return noRepetidos;
    }

    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 1 };
        List<int> noRepetidos = NoSeRepiten(numeros);

        Console.WriteLine("Números que no se repiten:");
        foreach (int num in noRepetidos)
        {
            Console.Write(num + " ");
        }
    }
}


Claro, aquí tienes ejemplos específicos en C# para cada uno de los métodos mencionados:

Método para Obtener Números Primos en C#:
csharp
Copy code
using System;
using System.Collections.Generic;

class Program
{
    static List<int> ObtenerPrimos(int n)
    {
        List<int> primos = new List<int>();
        for (int num = 2; num <= n; num++)
        {
            bool esPrimo = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                primos.Add(num);
            }
        }
        return primos;
    }

    static void Main()
    {
        int limite = 50;
        List<int> primosEnLimite = ObtenerPrimos(limite);
        
        Console.WriteLine("Números primos hasta " + limite + ":");
        foreach (int primo in primosEnLimite)
        {
            Console.Write(primo + " ");
        }
    }
}
Método para Obtener Números que no se Repiten en C#:
csharp
Copy code
using System;
using System.Collections.Generic;

class Program
{
    static List<int> NoSeRepiten(List<int> array)
    {
        List<int> noRepetidos = new List<int>();
        HashSet<int> elementosUnicos = new HashSet<int>();

        foreach (int num in array)
        {
            if (elementosUnicos.Add(num))
            {
                noRepetidos.Add(num);
            }
        }

        return noRepetidos;
    }

    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 1 };
        List<int> noRepetidos = NoSeRepiten(numeros);

        Console.WriteLine("Números que no se repiten:");
        foreach (int num in noRepetidos)
        {
            Console.Write(num + " ");
        }
    }
}

Método para Obtener Números que Más se Repiten en C#

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> MasRepetidos(List<int> array)
    {
        Dictionary<int, int> contador = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (contador.ContainsKey(num))
            {
                contador[num]++;
            }
            else
            {
                contador[num] = 1;
            }
        }

        List<int> masRepetidos = contador.Where(pair => pair.Value > 1).Select(pair => pair.Key).ToList();
        return masRepetidos;
    }

    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 1 };
        List<int> masRepetidos = MasRepetidos(numeros);

        Console.WriteLine("Números que más se repiten:");
        foreach (int num in masRepetidos)
        {
            Console.Write(num + " ");
        }
    }
}

```
 **La manipulación de arrays es esencial en la programación para gestionar conjuntos de datos de manera eficiente. En el contexto de C#, se pueden implementar diversos métodos para realizar tareas específicas, como obtener números primos, identificar números que no se repiten y encontrar los números que más se repiten. Estas operaciones demuestran la versatilidad y potencia de los arrays en la resolución de problemas matemáticos y de análisis de datos. La utilización de estructuras de datos adicionales, como conjuntos y diccionarios, complementa estas operaciones, ofreciendo soluciones más eficientes y elegantes. En resumen, el conocimiento y aplicación efectiva de la manipulación de arrays son fundamentales para desarrolladores que buscan optimizar sus programas y resolver una variedad de problemas computacionales**.



