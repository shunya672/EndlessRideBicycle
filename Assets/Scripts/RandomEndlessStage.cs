using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEndlessStage : MonoBehaviour
{
    

    public GameObject[] stage;
    float timer = -5.5f;
    float spawnedTime = 2.8f;



    /*
    public GameObject stage;
    GameObject[] step = new GameObject[10];
    float speed = 15;
    float disappear = -50;
    float respawn = 200;
    */

    /*
    public List<GameObject> course;
    GameObject[] step = new GameObject[3];

    float disappear = -50;
    float respawn = 100;
    */

    /*
    void StageMoveLeft()
    {
        
        this.transform.position -= new Vector3(stageMoveSpeed * Time.deltaTime, 0, 0);
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        
        //Invoke("StageMoveLeft", countDownTimer);



        /*
        for(int i = 0; i < step.Length; i++)
        {
            step[i] = Instantiate(stage, new Vector3(30 * i, 0, 0), Quaternion.identity);
        }
        */

        /*
        for(int i = 0; i < step.Length; i++)
        {
            step[i] = Instantiate(course[i], new Vector3(30 * i, 0, 0), Quaternion.identity);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("StageMoveLeft", countDownTimer);

        timer += Time.deltaTime;
        if(timer > spawnedTime)
        {
            StageGenerate();
            timer = 0;
        }


        /*
        for(int i = 0; i < step.Length; i++)
        {
            step[i].gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            if(step[i].gameObject.transform.position.x < disappear)
            {
                //ChangeScale(i);
                step[i].gameObject.transform.position = new Vector3(respawn, 0, 0);
            }
        }
        */

        /*
        for(int i = 0; i < step.Length; i++)
        {
            //step[i].gameObject.transform.position -= new Vector3(stageMoveSpeed * Time.deltaTime, 0, 0);
            if(step[i].gameObject.transform.position.x < disappear)
            {
                step[i].gameObject.transform.position = new Vector3(respawn, 0, 0);
            }
        }
        */
    }
    
    void StageGenerate()
    {
        
        Instantiate(stage[Random.Range(0,10)], new Vector3(30, 0, 0), Quaternion.identity);        
    }
}
