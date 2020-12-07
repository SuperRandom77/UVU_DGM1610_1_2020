using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outofbounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float topBound = 30;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        //Destroys objects that go out of bounds
        if(transform.position.z > topBound) {
            Destroy(gameObject); }

        else if(transform.position.z < bottomBound)   {
            Destroy(gameObject); }
}

    }
