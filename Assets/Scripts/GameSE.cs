using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSE : MonoBehaviour
{
    //[SerializeField]
    AudioSource audioSource;
    public AudioClip audioRaceStart;
    //public AudioClip crashSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        Invoke("PlayRaceStartSound", 4.0f);
    }

    void PlayRaceStartSound()
    {
        
        audioSource.PlayOneShot(audioRaceStart);
        //audioSource.clip = audioRaceStart;
        //audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
