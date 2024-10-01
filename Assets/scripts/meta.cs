using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class meta : MonoBehaviour
{
    [SerializeField]
    GameObject final;

    [SerializeField]
    TextMeshProUGUI temporisador;

    float Tiempo = 0f;
    bool jugando = true;
    private void Update()
    {
        if (jugando == true)
        {
            Tiempo = Tiempo + Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            final.SetActive(true);
            other.GetComponent<jugador>().enabled = false;
            jugando = false;
            temporisador.text = Tiempo.ToString();
        }
    }
}
