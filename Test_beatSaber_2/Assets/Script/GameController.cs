using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public TMPro.TextMeshPro scoreLabel;
    public TextMesh scoreLabel;
    public int score = 0;
    //public int hp = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        scoreLabel.text = "Score : " + score;
        getScore();
        //hpLabel.text = "Live : " + hp;

        
    }
    public void getScore()
    {
        score = saberL.scoreL + saberR.scoreR;
    }

    //public void getDamage()
    //{
    //    hp = hp - 1;
    //}
}
