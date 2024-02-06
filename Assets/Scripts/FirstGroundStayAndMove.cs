using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGroundStayAndMove : MonoBehaviour
{
    
    float speed = 18.0f;

    float startTimer = -5.5f;

    // Start is called before the first frame update
    void Start()
    {
        startTimer = -5.5f;
        Destroy(this.gameObject, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("CountDownTimer", 5.5f);
        if(startTimer < 1.0f)
        {
            startTimer += Time.deltaTime;
        }
        if(startTimer >= 0.0f)
        {
            this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    /*
    void CountDownTimer()
    {
        
        this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }
    */
}
