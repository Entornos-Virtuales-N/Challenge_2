using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que colisiona es el perro
        if (other.CompareTag("Dog"))
        {
            // Destruye la pelota
            Destroy(gameObject);
        }
    }
}
