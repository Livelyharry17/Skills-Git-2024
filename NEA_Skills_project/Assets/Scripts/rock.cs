using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    GameObject Dino;
    // Start is called before the first frame update
    void Start()
    {
        Dino = GameObject.FindGameObjectWithTag("Player");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You rock my world");
        Dino.SendMessage("resetPosition");
    }
}
