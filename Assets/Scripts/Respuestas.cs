using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuestas : MonoBehaviour
{
    public bool esCorrecto = false;

    public void Respuesta()
    {
        if (esCorrecto)
        {
            Debug.Log("correcto");
            QuizManager.correct();
        }

        else
        {
            Debug.Log("Incorrecto");
        }
    }

}
