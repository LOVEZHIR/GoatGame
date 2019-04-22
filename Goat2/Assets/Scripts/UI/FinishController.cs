using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour
{
    public void BackToMenubtn(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void Retry(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
