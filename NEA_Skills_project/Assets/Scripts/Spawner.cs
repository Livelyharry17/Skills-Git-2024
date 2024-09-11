using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject endSign;
    bool Spawned;
    Vector3 SpawnedPosition;
    // Start is called before the first frame update
    void Start()
    {
        Spawned = false;
        SpawnedPosition = new Vector3(32.1258f, 2.591703f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSign()
    {
        if(Spawned == false)
        {
            Instantiate(endSign,SpawnedPosition, Quaternion.identity);
            Spawned = true;
            Debug.Log("Sign Spawned");
        }
    }
}
