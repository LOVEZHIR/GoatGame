using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFinishLogic : MonoBehaviour
{
    public GameObject flag;
    private Flag fl;
    public GameObject gameController;
    public GameObject endScreen;
    private GameController controller;
    public Text timer;
    private float currTime;
    public GameObject Player;
    private Mover mover;

    void Start()
    {
        mover = Player.GetComponent<Mover>();
        fl = flag.GetComponent<Flag>();
        controller = gameController.GetComponent<GameController>();
    }

    void OnTriggerExit(Collider other)
    {
        if (!fl.PlayerVisited) controller.Racing = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (fl.PlayerVisited)
        {
            currTime = controller.time;
            endScreen.SetActive(true);
            controller.timer.enabled = false;
            mover.enabled = false;
            timer.text = currTime.ToString("f2");
            Time.timeScale = 1;
        }
    }
}
