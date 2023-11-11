using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<PreguntaYRespuesta> QnA;
    public GameObject[] opciones;
    public int currentQuestion;

    public Text textoPregunta;

    private void Start()
    {
        generaPreguntas();
    }

    void setAnswers()
    {
        for (int i = 0; i < opciones.Length; i++)
        {
            opciones[i].GetComponent<Respuestas>().esCorrecto = false;
            opciones[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Pregunta[i];

            if(QnA[currentQuestion].respuestaCorrecta == i + 1)
            {
                opciones[i].GetComponent<Respuestas>().esCorrecto = true;

            }
        }
    }

    void generaPreguntas()
    {
        currentQuestion = Random.Range(0, QnA.Count);

        textoPregunta.text = QnA[currentQuestion].Pregunta;
        setAnswers();

        QnA.RemoveAt(currentQuestion);
    }
}
