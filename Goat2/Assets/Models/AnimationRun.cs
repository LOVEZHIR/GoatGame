using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRun : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animegoat;
    void Start()
    {
        animegoat = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animegoat.Play("Run", -1, 0f);
        }
    }
}
