using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntuacionActuador : MonoBehaviour
{
    PuntuacionNotificador[] puntuacionNotificadores;
    Desafio desafio;
    int puntuacion = 0;
    private TextMeshProUGUI textoPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        textoPuntuacion = GetComponent<TextMeshProUGUI>();
        puntuacionNotificadores = FindObjectsOfType<PuntuacionNotificador>();
        desafio = FindObjectOfType<Desafio>();
        desafio.OnResetearContador += ResetearPuntuacion;
        foreach (PuntuacionNotificador puntuacionNotificador in puntuacionNotificadores)
        {
            puntuacionNotificador.OnIncrementarPuntuacion += IncrementarPuntuacion;
        }
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }

    void IncrementarPuntuacion(int puntos)
    {
        puntuacion += puntos;
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }

    void ResetearPuntuacion()
    {
        puntuacion = 0;
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }
    
}
