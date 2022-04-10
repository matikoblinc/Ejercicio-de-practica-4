using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    int num1 = 0;

    void Start()
    {
        num1 = num1 + 2;
        Debug.Log("el valor es: " + num1);

        num1 = num1 * num1;
        Debug.Log("el valor de la multi es: " + num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//. Realizá un programa donde se cree una variable entera llamada num1, que inicialmente  valdrá 0.
//Luego incrementá su valor en 2 y mostralo por pantalla. Después mostrá el  resultado de multiplicarlo por sí mismo. 
