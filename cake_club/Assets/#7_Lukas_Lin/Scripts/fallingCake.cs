using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingCake : MonoBehaviour
{
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
