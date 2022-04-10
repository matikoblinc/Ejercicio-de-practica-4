using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public int num1;
    public int num2;
    int suma;
    int producto;

    void Start()
    {
        suma = num1 + num2;
        Debug.Log("el resultado de la suma es: " + suma);

        producto = num1 * num2;
        Debug.Log("El resultado del producto es: " + producto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//Realizá un programa que, siendo num1 y num2 variables enteras ingresadas por el susario,
//realice la operación correspondiente y muestre el resultado en pantalla: 
//a.Suma
//b.Producto
