//Nombre: Melissa Estela Oscoy Parada 
//Profesor: Josue Israel Rivas Diaz
//Materia: Estructura de Datos 
//Clase: Movimiento en determinado tiempo
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se programan 3 objetos para que salieran a distintos tiempos
public class Movimiento : MonoBehaviour
{
    #region Variables
    //cada que inicialce un valor Flotante el numero debe terminar con la letra F
    float velocidad = 1f;
    public float tiempo = 0;


    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += 0.5f*Time.deltaTime;

        if (tiempo>=1.5f)
        {
            transform.Translate(Vector3.forward * velocidad);
        }

        
    }
}//Y ya fin
