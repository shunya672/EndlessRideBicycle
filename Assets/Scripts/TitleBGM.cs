using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBGM : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip audioTitleBGM;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        Invoke("PlayTitleBGM", 1.0f);
    }

    void PlayTitleBGM()
    {
        
        audioSource.clip = audioTitleBGM;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
