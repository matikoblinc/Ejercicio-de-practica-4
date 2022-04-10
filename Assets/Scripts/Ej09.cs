using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capital1;
    public float capital2;
    public float capital3;

    float porcentaje1;
    float porcentaje2;
    float porcentaje3;

    float montoTotal;
    float multi = 100;


    void Start()
    {
        montoTotal = capital1 + capital2 + capital3;

        porcentaje1 = capital1 / montoTotal * 100;
        porcentaje2 = capital2 / montoTotal * 100;
        porcentaje3 = capital3 / montoTotal * 100;

        Debug.Log("Nombre: " + nombre1 + ", capital aportado: $" + capital1 + ", Porcentaje del capital: %" + porcentaje1 +
            "Monto total aportado: $" + montoTotal);
        Debug.Log("Nombre: " + nombre2 + ", capital aportado: $" + capital2 + ", Porcentaje del capital: %" + porcentaje2 +
            "Monto total aportado: $" + montoTotal);
        Debug.Log("Nombre: " + nombre3 + ", capital aportado: $" + capital3 + ", Porcentaje del capital: %" + porcentaje3 +
            "Monto total aportado: $" + montoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una
//(indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.  
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: % .... , Monto total aportado: $ …. 
