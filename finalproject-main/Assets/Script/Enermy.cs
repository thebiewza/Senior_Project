using Oculus.Platform.Samples.VrBoardGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public float speed = 0.05f;
    public float DelayDestroy = 10.0f;
    float startTime;
    public string weaponTag;
    public GameObject explode;
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += speed * this.gameObject.transform.forward;
        if (Time.time - startTime >= DelayDestroy)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == weaponTag)
        {
            Destroy(this.gameObject);
            Instantiate(explode, transform.position, transform.rotation);
            gameController.getScore();
        }
        if (other.gameObject.tag == "Player")
        {
            gameController.getDamage();
            Destroy(this.gameObject);
        }
    }
}
