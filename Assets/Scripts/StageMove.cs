using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMove : MonoBehaviour
{
    
    public float speed = 18.0f;
    

    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        
        
    }
}
