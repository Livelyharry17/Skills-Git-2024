using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DinoMovement : MonoBehaviour
{
    float speed = 0f;
    Rigidbody2D rb;
    public int lives = 0;
    bool vulnerable = false;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.1f;
        rb = GetComponent<Rigidbody2D>();
        lives = 2;
        vulnerable = false;
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
        setLives();
        transform.SetPositionAndRotation( new Vector3 (-0.8208882f, 0.7700498f, 0), Quaternion.identity );
    }

    public void setLives()
    {
        lives -= 1;
        if (lives < 0 || vulnerable == true)
        {
            Debug.Log("End of Game");
            SceneManager.LoadScene("Lost");
        }
    }
    IEnumerator VulnerableDeBuff()
    {
        yield return new WaitForSeconds(5f);
        vulnerable = false;
        Debug.Log("vulnerable = false!");

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "MushroomPink")
        {
            lives += 1;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "vulnerable")
        {
            Destroy(other.gameObject);
            vulnerable = true;
            Debug.Log("vulnerable = true!");
            StartCoroutine("VulnerableDeBuff");
        }
        
    }
}
