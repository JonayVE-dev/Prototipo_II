using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PuntuacionNotificador : MonoBehaviour
{
    public int puntuacion = 10;
    public delegate void IncrementarPuntuacion(int puntos);
    public delegate void GenerarObjetivo(string nombreObjetivo);
    public event IncrementarPuntuacion OnIncrementarPuntuacion;
    public event GenerarObjetivo OnGenerarObjetivo;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            OnIncrementarPuntuacion(puntuacion);
            if (this.name.Contains("target"))
            {
                OnGenerarObjetivo("target");
            }
            else if (this.name.Contains("dummy"))
            {
                OnGenerarObjetivo("dummy");
            }
        }
        other.gameObject.transform.position = new Vector3(0, -100, 0);
    }
}
