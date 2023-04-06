using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearGameObj : MonoBehaviour
{
    public float DelayDestroy = 0.9f;
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime >= DelayDestroy)
        {
            Destroy(this.gameObject);
        }
    }
}
