using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej07 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;

    void Start()
    {
        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("todos los valores son iguales");
        }
        else if (num1 > num2 && num1 == num3 || num1 > num3 && num1 == num2 || num2 > num1 && num2 == num3 || num2 > num3 && num2 == num1 || num3 > num1 && num3 == num2 || num3 > num2 && num3 == num1)
        {
            Debug.Log("hay dos numeros iguales que cumplen con la condicion de ser el mayor");
        }
        else if (num1 > num2 && num1 > num3)
        {
            Debug.Log("el numero " + num1 + " es el mayor de todos");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("el numero " + num2 + " es el mayor de todos");
        }
        else if (num3 > num1 && num3 > num2)
        {
            Debug.Log("el numero " + num3 + " es el mayor de todos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//7. Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y  num3,
//muestre el valor del mayor de ellos.
//En caso de igualdad entre los tres imprimir "Los números son iguales".
//Test1: num1 = 12, num2 = 4, num3 = 7.Resultado esperado: El mayor número es num1  Test2: num1 = 2, num2 = 65, num3 = 8.
//Resultado esperado: El mayor número es num2 
