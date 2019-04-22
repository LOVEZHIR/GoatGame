using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public bool PlayerVisited = false;

    void OnTriggerEnter(Collider other)
    {
        PlayerVisited = true;
    }
}
