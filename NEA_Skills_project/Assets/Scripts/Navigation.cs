using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Navigation : MonoBehaviour
{
    private Canvas mainCamera;
    public TextMeshPro timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = Time.fixedTime.ToString("0.00");
    }

    public void ClickedButtonA()
    {
        Debug.Log("Button A Clicked!");
    }
    public void ClickedButtonB()
    {
        Debug.Log("Button B Clicked!");
    }
    public void ClickedExit()
    {
        Debug.Log("Exit Clicked!");
    }
}
