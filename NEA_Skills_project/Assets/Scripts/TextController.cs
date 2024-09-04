using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TextMeshPro mushroomCounter;
    GameObject[] totalMushrooms;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalMushrooms = GameObject.FindGameObjectsWithTag("MushroomRed");
        mushroomCounter.text = "Mushrooms: " + totalMushrooms.Length.ToString();
    }
}
