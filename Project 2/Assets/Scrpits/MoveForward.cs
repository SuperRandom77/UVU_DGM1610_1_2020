using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

        //move speed of the GameObject 
        public float speed = 10;


    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves the animal forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }

}
