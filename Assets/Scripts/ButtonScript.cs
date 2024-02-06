using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    AudioSource audioSource;
    
    public AudioClip audioBackToTitle;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
                
        
        //DontDestroyOnLoad(this);
    }

    
    

    
    public void GamePlayButton()
    {
        
        SceneManager.LoadScene("GameScene");
    }
    
    public void BackToTitleButton()
    {
        
        DontDestroyOnLoad(this);
        audioSource.PlayOneShot(audioBackToTitle);
        SceneManager.LoadScene("StartScene");        
    }

    public void ViewRankingButton()
    {        
        SceneManager.LoadScene("RankingScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
