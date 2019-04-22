using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{
    ObjectOffer offer;
    public GameObject Zone;
    MeshRenderer MeshRenderer;
    BoxCollider collider;
    void Start()
    {
        offer = GetComponent<ObjectOffer>();
        collider = Zone.GetComponent<BoxCollider>();
        MeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        offer.enabled = true;
        collider.enabled = true;
        MeshRenderer.enabled = false;
    }
}
