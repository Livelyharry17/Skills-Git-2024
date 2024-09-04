using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    float speed = 0f;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.1f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) 
        {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed,0,0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * 300);
        }
    }
    void resetPosition()
    {
        transform.SetPositionAndRotation( new Vector3 (-0.8208882f, 0.7700498f, 0), Quaternion.identity );
    }
}
