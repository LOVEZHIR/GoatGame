using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float koef = 1;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

    public float t;

    private float k;
    private float spd;
    private float spdToBack;

    public bool IsNormalSpeed = true;

    void Start()
    {
        k = koef;
        spd = speed;
        spdToBack = speed * 0.25f;
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)))
        {
            speed = spdToBack;
        }
        float translation = Input.GetAxis("Vertical") * speed * koef;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * koef;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (IsNormalSpeed)
        {
            koef = k;
            speed = spd;

        }

        
    }

    public void GetSlow()
    {
        IsNormalSpeed = false;
        speed *= 0.5f;
        Invoke("NormalizeSpeed", 10);
    }

    public void NormalizeSpeed()
    {
        IsNormalSpeed = true;
    }

    public void GetFast()
    {
        IsNormalSpeed = false;
        speed *= 1.5f;
        Invoke("NormalizeSpeed", 10);
    }
}
