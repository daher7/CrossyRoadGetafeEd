using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol : MonoBehaviour {

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();        // El pollo al morir provoca la llamada al audio de la muerte
        Destroy(other.gameObject); // Para destruir al pollo
    }
}
