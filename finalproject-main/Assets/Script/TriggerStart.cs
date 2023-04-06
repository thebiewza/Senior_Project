using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class TriggerStart : MonoBehaviour
{
    public float clickRate = 0.4f;
    public float nextClick = 0.0f;
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        if (gameController == null)
        {
            GameObject _gControler = GameObject.FindGameObjectWithTag("GameController") as GameObject;
            gameController = _gControler.GetComponent<GameController>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger) && Time.time > nextClick)
        {
            nextClick = Time.time + clickRate;
            gameController.getTriggerStart();
        }
    }
}
