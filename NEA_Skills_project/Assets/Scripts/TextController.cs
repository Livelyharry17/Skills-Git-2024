using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TextMeshPro mushroomCounter;
    public TextMeshPro livesCounter;
    public TextMeshPro gameTimer;
    GameObject[] totalMushrooms;
    int lives;
    GameObject Dino;
    // Start is called before the first frame update
    void Start()
    {
        Dino = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        totalMushrooms = GameObject.FindGameObjectsWithTag("MushroomRed");

        mushroomCounter.text = "Mushrooms: " + totalMushrooms.Length.ToString();

        lives = Dino.GetComponent<DinoMovement>().lives;

        livesCounter.text = "Lives: " + lives;

        gameTimer.text = "Time: " + Time.timeSinceLevelLoad.ToString("0.00");

        if(totalMushrooms.Length == 0)
        {
            Dino.SendMessage("SpawnSign");
        }
    }
    
}
