using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour {

    AudioSource audioSource1;

    private void Start()
    {
        audioSource1 = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource1.Play();
        Destroy(this.gameObject); // Eliminamos este objeto
        Debug.Log("Aggggg!!!! Me has comidoooooooo.......");
    }
}
