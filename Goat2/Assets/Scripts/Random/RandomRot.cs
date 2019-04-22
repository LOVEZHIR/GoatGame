using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var currRotY = transform.rotation.y;
        transform.rotation = new Quaternion(transform.rotation.x, Random.Range(-180f, 180f), transform.rotation.z, transform.rotation.w);

    }
}
