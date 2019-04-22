using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decreaser : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {
        var mover = other.GetComponent<Mover>();
        mover.koef = 0.25f;
    }

    void OnTriggerExit(Collider other)
    {
        var mover = other.GetComponent<Mover>();
        mover.koef = 1f;
    }
}
