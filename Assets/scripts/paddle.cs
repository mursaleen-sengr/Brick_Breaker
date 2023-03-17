using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float Speed= 2f;
   

    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(transform.position.x,-7.57f, 7.57f);
        transform.position = newPosition;
        newPosition.x = HorizontalInput * Speed*Time.deltaTime;
        newPosition.y = 0f;
        newPosition.z = 0f; 
        transform.position += newPosition;
        //transform.position += new Vector3(Input.GetAxis("Horizontal")*Speed*Time.deltaTime,0f,0f);
    }
   
}
