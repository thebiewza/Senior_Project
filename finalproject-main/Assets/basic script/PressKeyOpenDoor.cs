using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PressKeyOpenDoor : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeObject;
    public GameObject AnimeObject1;
    [SerializeField] public string Destination;
    [SerializeField] public string Destination1;
    //public GameObject ThisTrigger;
    //public AudioSource DoorOpenSound;
    public bool Action = false;
    void Start()
    {
        Instruction.SetActive(false);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }


    void Update()
    {
        OpenTheDoor();
    }

    public void OpenTheDoor()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                Instruction.SetActive(false);
                AnimeObject.GetComponent<Animator>().Play(Destination);
                AnimeObject1.GetComponent<Animator>().Play(Destination1);
                //ThisTrigger.SetActive(false);
                //DoorOpenSound.Play();
                Action = false;
            }
        }
    }
}


