using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour {

    private Rigidbody rb;
    [SerializeField] int fuerza = 100;
    [SerializeField] Transform posPies;

	void Start () {
        // Asignamos el rigidbody al objeto
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {

        // Vamos a programar el movimiento del pollo
        if (Input.GetKeyDown("w"))
        {
            // Saber si los pies están tocando el suelo
            // Para proyectar una esfera y saber sobre qué objetos choca
            Collider[] cols = Physics.OverlapSphere(
                posPies.position, 
                0.1f,
                LayerMask.NameToLayer("Terreno"));
            
            for(int i = 0; i < cols.Length; i++)
            {
                Debug.Log("Estoy tocando con: " + i);
            }

            rb.AddForce(new Vector3(0, 1, 1) * fuerza); // Lo que queremos es que avance
        }
        else if (Input.GetKeyDown("a"))
        {
            rb.AddForce(new Vector3(-1, 1, 0) * fuerza); // Lo que queremos es que salte
        }
        else if (Input.GetKeyDown("d"))
        {
            rb.AddForce(new Vector3(1, 1, 0) * fuerza); // Lo que queremos es que salte
        }
        else if (Input.GetKeyDown("s"))
        {
            rb.AddForce(new Vector3(0, 1, -1) * fuerza); // Lo que queremos es que salte
        }
    }
}
