using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed;
    public float gravity = 20;
    
    public float horizontalInput;
    public float verticalInput;
    public float jumpInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");
    jumpInput = Input.GetAxis("Jump");
    
        // rotates the truck
         transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
         
        // Moves the truck forward
         transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
         
         // Makes the truck jump
        transform.Translate(Vector3.up * Time.deltaTime * gravity * jumpInput);
        
    }
}
