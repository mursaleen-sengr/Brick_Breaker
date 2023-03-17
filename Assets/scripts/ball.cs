using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ball : MonoBehaviour
{
    int scoreCount = 0;
    public Transform surface;
    public float Speed = 1f;
    bool check = true;
    bool isgrounded = true;
    public Vector2 initialpositionofball;
    public Vector2 initialpositionofsurface;
    

   

    // Start is called before the first frame update
    void Start()
    {
        initialpositionofball= transform.position;
        initialpositionofsurface = surface.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& isgrounded) {
            isgrounded= false;
            if (check)
            {
                check= false;
                transform.parent = null;
            }
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*Speed ,ForceMode2D.Force);
        
        }
        
        if (scoreCount == 62)
        {
            SceneManager.LoadScene("level1");
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("downCollider"))
        {
            transform.position = initialpositionofball;
            surface.transform.position = initialpositionofsurface;
            isgrounded= true;
            
            
        }
        if (collision.gameObject.CompareTag("enemy"))
        {

            Destroy(collision.gameObject);
            count();

        }
    }
    public void count()
    {
        scoreCount++;
    }
}
