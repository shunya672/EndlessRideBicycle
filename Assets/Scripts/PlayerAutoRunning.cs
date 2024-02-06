using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutoRunning : MonoBehaviour
{
    //public float rightSpeed;
    public float firstJump;
    public float secondJump;
    public float countDownTimer;
    float jumpable = 0;

    Rigidbody2D rb;
    int jumpCount = 0;

    Animator animator;

    AudioSource audioSource;
    public AudioClip firstJumpSE;
    public AudioClip secondJumpSE;

    
    
    void pedalMove()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        animator.SetBool("pedal", true);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        animator = this.gameObject.GetComponent<Animator>();

        //animator.SetBool("pedal", false);
        Invoke("pedalMove", countDownTimer);

        
        jumpable = 0;
        jumpCount = 0;

        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (jumpable < countDownTimer + 2.0f)
        {
            jumpable += Time.deltaTime;
        }
        

        
        //AutoRightMove();
        Jump();
    }

    /*
    void AutoRightMove()
    {
        this.transform.position += new Vector3(rightSpeed * Time.deltaTime, 0, 0);
    }*/

    void Jump()
    {
        if (jumpable > countDownTimer + 0.8f)
        {
            if (jumpCount == 0 && Input.GetMouseButtonDown(0) == true)
            {
                rb.velocity = new Vector3(0, firstJump, 0);
                jumpCount = 1;
                animator.SetBool("firstJump", true);

                audioSource.clip = firstJumpSE;
                audioSource.Play();
            }
            else if (jumpCount == 1 && Input.GetMouseButtonDown(0) == true)
            {
                rb.velocity = new Vector3(0, secondJump, 0);
                jumpCount = 2;
                animator.SetBool("secondJump", true);

                audioSource.clip = secondJumpSE;
                audioSource.Play();
            }
        }        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("ground"))
        {
            jumpCount = 0;            
        }

        
        if(col.gameObject.CompareTag("ground") || col.gameObject.CompareTag("wall"))
        {
            
            animator.SetBool("firstJump", false);
            animator.SetBool("secondJump", false);            
        }

        
        if (col.gameObject.CompareTag("wall"))
        {
            
            animator.SetBool("pedal", false);

            
            

            
        }        
    }

}
