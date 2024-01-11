using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Desafio : MonoBehaviour
{
    public double tiempoMaximo = 30;
    private double tiempoRestante;
    private GameObject[] Targets;
    private GameObject[] Dummys;
    private bool isActivated = false;
    private int activeTarget = 0;
    private int activeDummy = 0;

    public delegate void ResetearContador();
    public event ResetearContador OnResetearContador;

    private TextMeshProUGUI textoTiempo;
    
    PuntuacionNotificador[] puntuacionNotificadores;
    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = tiempoMaximo;
        puntuacionNotificadores = FindObjectsOfType<PuntuacionNotificador>();
        foreach (PuntuacionNotificador puntuacionNotificador in puntuacionNotificadores)
        {
            puntuacionNotificador.OnGenerarObjetivo += GenerarObjetivo;
        }
        GameObject targetParent = GameObject.Find("Targets");
        GameObject dummyParent = GameObject.Find("Dummys");
        Targets = new GameObject[targetParent.transform.childCount];
        for (int i = 0; i < targetParent.transform.childCount; i++)
        {
            Targets[i] = targetParent.transform.GetChild(i).gameObject;
        }

        Dummys = new GameObject[dummyParent.transform.childCount];
        for (int i = 0; i < dummyParent.transform.childCount; i++)
        {
            Dummys[i] = dummyParent.transform.GetChild(i).gameObject;

        }
        textoTiempo = GameObject.Find("Canvas/tiempo").GetComponent<TextMeshProUGUI>();
        textoTiempo.text = "Tiempo: " + tiempoRestante.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {   
        if ((Input.GetKeyDown(KeyCode.R) && isActivated) || tiempoRestante <= 0)
        {
            OnResetearContador();

            for (int i = 0; i < Targets.Length; i++)
            {
                Targets[i].SetActive(true);
            }
            for (int i = 0; i < Dummys.Length; i++)
            {
                Dummys[i].SetActive(true);
            }
            isActivated = false;
            tiempoRestante = tiempoMaximo;
            textoTiempo.text = "Tiempo: " + tiempoRestante.ToString("F2");
        } else if (Input.GetKeyDown(KeyCode.Space) && !isActivated)
        {
            OnResetearContador();
            isActivated = !isActivated;

            // borra todos los targets y dummys y genera uno nuevo de cada en una posición aleatoria de las que hay en el array
            for (int i = 0; i < Targets.Length; i++)
            {
                Targets[i].SetActive(false);
            }
            for (int i = 0; i < Dummys.Length; i++)
            {
                Dummys[i].SetActive(false);
            }
            activeTarget = Random.Range(0, Targets.Length);
            activeDummy = Random.Range(0, Dummys.Length);
            Targets[activeTarget].SetActive(true);
            Dummys[activeDummy].SetActive(true);
        }
        if (isActivated)
        {
            tiempoRestante -= Time.deltaTime;
            textoTiempo.text = "Tiempo: " + tiempoRestante.ToString("F2");
        }
    }

    void GenerarObjetivo(string nombreObjetivo)
    {
        if (nombreObjetivo == "target" && isActivated)
        {
            Targets[activeTarget].SetActive(false);
            int newTarget = Random.Range(0, Targets.Length);
            while (newTarget == activeTarget)
            {
                newTarget = Random.Range(0, Targets.Length);
            }
            activeTarget = newTarget;
            Targets[activeTarget].SetActive(true);
            
        }
        else if (nombreObjetivo == "dummy" && isActivated)
        {
            Dummys[activeDummy].SetActive(false);
            int newDummy = Random.Range(0, Dummys.Length);
            while (newDummy == activeDummy)
            {
                newDummy = Random.Range(0, Dummys.Length);
            }
            activeDummy = newDummy;
            Dummys[activeDummy].SetActive(true);
        }
    }
}
