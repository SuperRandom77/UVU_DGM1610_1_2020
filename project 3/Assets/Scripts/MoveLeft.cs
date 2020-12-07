using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController PlayerControllerScript;
    private float leftbound = -15; 
    private void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if(PlayerControllerScript.gameOver == false)
        {
            //Moves the GameObject left at a set speed
             transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
        {
            //Destroys gameObject if it exits parameters
            Destroy(gameObject);
        }
    }
}   
