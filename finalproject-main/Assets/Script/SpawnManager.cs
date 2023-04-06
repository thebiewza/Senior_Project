using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject monster;
    public float timeElapsed;
    public float ItemCycle;
    public bool isRand = false;

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > ItemCycle)
        {
            GameObject temp;
            temp = (GameObject)Instantiate(monster);
            isRand = true;
            Vector3 positionMonster = temp.transform.position;
            temp.transform.position = new Vector3(Random.Range(-2.3f, 2.3f), 0.3f, positionMonster.z);
            timeElapsed -= ItemCycle;
        }

        if (isRand)
        {
            RandomSpawnRate();
        }
    }

    void RandomSpawnRate()
    {
        ItemCycle = Random.Range(0.5f, 5f);
        isRand = false;
    }
}
