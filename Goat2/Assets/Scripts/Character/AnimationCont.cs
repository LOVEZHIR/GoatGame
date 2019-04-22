using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCont : MonoBehaviour
{
    public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
            obj.GetComponent<Animator>().SetBool("Going", true);
        else obj.GetComponent<Animator>().SetBool("Going", false);
        obj.GetComponent<Animator>().speed = obj.GetComponent<Mover>().speed * obj.GetComponent<Mover>().koef /8;


    }
}
