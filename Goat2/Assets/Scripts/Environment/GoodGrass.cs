using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodGrass : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var mover = other.GetComponent<Mover>();
        mover.GetFast();
    }
}
