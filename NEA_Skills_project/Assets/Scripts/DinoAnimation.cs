﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnimation : MonoBehaviour
{
    Animator MyAnimator;
    // Start is called before the first frame update
    void Start()
    {
        MyAnimator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyAnimator.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            MyAnimator.SetBool("dead", true);
            
        }
        //else if (Input.GetKeyUp(KeyCode.DownArrow))
        //}
            //MyAnimator.SetBool("dead", false);
        //}
        else if (Input.GetKey(KeyCode.R))
        {
            MyAnimator.SetBool("run", true);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            MyAnimator.Play("Jump");
        }
        else if (Input.GetKeyUp (KeyCode.Q) && MyAnimator.GetBool("dead") == true)
        {
            MyAnimator.SetBool("dead",false);
        }
        else if (MyAnimator.GetBool("dead")==false)
        { 
            MyAnimator.SetBool("idle", true);
            MyAnimator.SetBool("walk", false);
            MyAnimator.SetBool("run", false);

        }

    }
}
