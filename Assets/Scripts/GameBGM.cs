using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBGM : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip audioGameBGM;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        Invoke("PlayGameBGM", 5.95f);
    }       

    void PlayGameBGM()
    {
        
        audioSource.clip = audioGameBGM;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
