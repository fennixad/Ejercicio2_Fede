using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    private string resultado1, resultado2, resultado3;

    [SerializeField]
    private int num, num2;

    private int x = 3, y = 5, i = 2, j = 4;

    void Start()
    {
        MuestraMayorMenorIgual(num);
        ComparaDosNumeros(num, num2);
        MuestraNumero();
    }

    void MuestraMayorMenorIgual(int num)
    {
        if (num > 10)
        {
            resultado1 = "El número es mayor a 10";

        } else if (num == 10)
        {
            resultado1 = "El número es igual a 10";

        } else
        {
            resultado1 = "El número es menor a 10";
        }

        print(resultado1);
    }

    void ComparaDosNumeros(int num, int num2)
    {
        if (num > num2)
        {
            resultado2 = num + " es mayor que " + num2;

        } else if (num < num2)
        {
            resultado2 = num + " es menor que " + num2;

        } else
        {
            resultado2 = num + " es igual a " + num2;
        }

        print(resultado2);
    }

    void MuestraNumero()
    {
        if (x + y == i + j)
        {
            resultado3 = "La suma de x, y, i y j es: " + (x + y + i + j);
        }
        else if (x == y && i == j)
        {
            resultado3 = "La suma de i y j es: " + (i + j);
        }
        if (x == y && i != j)
        {
            resultado3 = "La resta de i y j es: " + (i - j);
        }
        else
        {
            resultado3 = "La multiplicación de x e y es: " + x * y;
        }

        print(resultado3); 
    }
}
