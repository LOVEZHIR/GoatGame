using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOffer: MonoBehaviour
{
    public float timeUntilRemove = 5f;
    public GameObject[] objects;
    private float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeUntilRemove)
        {
            foreach(var element in objects)
            {
                element.SetActive(false);
            }    
        }    
    }
}
