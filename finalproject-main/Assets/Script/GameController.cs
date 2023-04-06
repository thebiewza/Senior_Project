using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool isStart = false;
    public bool isGameover = false;
    public GameObject startGroup, panelGroup, gameoverGroup;
    public int score = 0;
    public int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        startGroup.SetActive(true);
        panelGroup.SetActive(false);
        gameoverGroup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            startGroup.SetActive(false);
            panelGroup.SetActive(true);
            gameoverGroup.SetActive(false);

        }
        else
        {
            startGroup.SetActive(true);
            panelGroup.SetActive(false);
            gameoverGroup.SetActive(false);

        }

        if (isGameover)
        {
            //จบเกม
            startGroup.SetActive(false);
            panelGroup.SetActive(true);
            gameoverGroup.SetActive(false);

        }
    }

    public void getTriggerStart()
    {
        isStart = true;
    }

    public void getScore()
    {
        score = score + 1;      
    }

    public void getDamage()
    {
        hp = hp - 1;
    }
}
