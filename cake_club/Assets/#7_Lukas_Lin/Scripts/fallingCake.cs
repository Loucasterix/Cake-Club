using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingCake : MonoBehaviour
{
    /* todo
     * - Kameraführung: evtl Kamera rotieren und Tisch zeigen
     * - Cake steuern
     * - Wo werden die Bällchen aufkommen beim Kuchen? Wieder Licht setzen oder X für Aufkomm-Stelle
     * - WebGL Export: genug Zeit einplanen, Fehler sind wohl üblich 
     */
    public GameObject cake;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Cake")
        {
            Rigidbody cubeRigidbody = collision.GetComponent<Rigidbody> ();
            cubeRigidbody.isKinematic = false;
        }
    }
}
