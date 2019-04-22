using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    private bool Playing = true;
    public bool Racing = false;
    public Text timer;
    public float time;

    public void BackToMenubtn(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Resumebtn()
    {
        panel.SetActive(false);
        Playing = true;
    }

    void Start()
    {
        panel.SetActive(false);
        time = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(Playing);
            Playing = !Playing;
        }
        if (Playing) Time.timeScale = 1;
        else Time.timeScale = 0;
        if (Racing)
        {
            time += Time.deltaTime;
            timer.text = time.ToString("f2");
        }
        
    }
}
