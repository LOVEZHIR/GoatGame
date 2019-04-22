using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGrass : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var mover = other.GetComponent<Mover>();
        mover.GetSlow();
    }
}
