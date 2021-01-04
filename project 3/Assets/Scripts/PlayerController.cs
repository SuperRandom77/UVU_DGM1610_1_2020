using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    //Jump method
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //Stops double jumping
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            //Plays jump sound
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            //Stops dirt particle effect when game is over
            dirtParticle.Stop();
        }
    }
    //Tests to see if the player is on the ground
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //plays dirt particle when landing on the ground
            dirtParticle.Play();
        }
        //Game over function when collision with "Obstacle"
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            //plays death animation
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            //Plays crash sound
            playerAudio.PlayOneShot(crashSound, 1.0f);
            //Stops dirt particle when player collides with an object
            dirtParticle.Stop(); 
        }
    }
}
